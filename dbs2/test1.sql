SET search_path TO public

  /*
    Assingment Number 1.1
  */
  SELECT s.year_entered, p.party, count(p.id)
  FROM president p inner join state s on p.state_id_born = s.id
  WHERE (p.party in ('WHIG','DEMOCRATIC','REPUBLICAN')) and s.year_entered < 1800
  GROUP BY ROLLUP (party, year_entered)
  order by year_entered;

   /*
    Assingment Number 1.2
  */
  SELECT s.name, p.party, count(p.id)
  FROM president p inner join state s on p.state_id_born = s.id
  WHERE (p.party in ('DEMOCRATIC','REPUBLICAN')) and s.name in('NEW YORK','VIRGINIA','OHIO')
  GROUP BY CUBE (party, s.name);


  /*
    Assingment Number 1.3
  */

  SELECT election_year, winner_loser_indic, count(candidate), avg(votes)
  FROM election
  GROUP BY GROUPING SETS ((),(election_year),(election_year,winner_loser_indic))
  having election_year in(
  SELECT election_year
  FROM election
  group by election_year
  having count(candidate) > 4);

   /*
    Assingment Number 2.1
  */
    SELECT p.name, p.death_age, avg(death_age) over (PARTITION BY  party) as avg_deathage_party,
                                avg(death_age) over (PARTITION BY state_id_born) as avg_deathage_state
    FROM president p
    Where p.state_id_born in (
                              SELECT p2.state_id_born
                              FROM president p2
                              WHERE p2.death_age is not null and p.state_id_born = p2.state_id_born
                            );


