male('Paul').
male('Albert').
male('Vernon').
male('James').
male('Dudley').
male('Harry').

female('Helen').
female('Ruth').
female('Petunia').
female('Lili').

parent_of('Paul', 'Petunia').
parent_of('Helen', 'Petunia').
parent_of('Paul', 'Lili').
parent_of('Helen', 'Lili').

parent_of('Albert', 'James').
parent_of('Ruth', 'James').

parent_of('Vernon', 'Dudley').
parent_of('Petunia', 'Dudley').


parent_of('James', 'Harry').
parent_of('Lili', 'Harry').


% Father and Mother of rule %

father_of(Father,Child)  :-  male(Father), parent_of(Father,Child).
mother_of(Mother,Child)  :-  female(Mother), parent_of(Mother,Child).

% Grandfather and GrandMother of rule %

grandfather_of(Grandfather, Child) :- male(Grandfather),parent_of(Father,Child), father_of(Grandfather, Father).

grandmother_of(GrandMother, Child) :- female(GrandMother),parent_of(Mother,Child), mother_of(GrandMother, Mother).

% Sister %

siblings_of(Sibling, Person) :- mother_of(Mother1, Sibling), mother_of(Mother2,Person), Mother1 = Mother2,
father_of(Father1, Sibling), father_of(Father2, Person), Father1 = Father2,
Sibling \= Person.

sister_of(Sister, Person) :- siblings_of(Sister,Person), female(Sister).
brother_of(Brother, Person) :- siblings_of(Brother,Person), male(Brother).

ancestor_of(Ancestor, Decendant) :-
  parent_of(Ancestor, Decendant).

ancestor_of(Ancestor, Decendant) :-
  parent_of(Ancestor, Child),
  ancestor_of(Child, Decendant).


  not_parent(Parent, Child) :-
    not(parent_of(Parent, Child)).

    aunt_of(Aunt , Person) :- female(Aunt), parent_of(Parent, Person), siblings_of(Aunt,Parent).
    uncle_of(Uncle, Person) :- male(Uncle), parent_of(Parent, Person), siblings_of(Uncle,Parent).

/* Aunt of and Uncle of %



 Does Harry have an aunt? Who?
 aunt_of(Aunt, 'Harry').
- Aunt = 'Petunia' ;

 Who are the grandparents of Harry?
 grandfather_of(Grandfather, 'Harry');
 grandmother_of(Grandmother, 'Harry').
- Grandfather = 'Paul' ;
- Grandfather = 'Albert' ;
- Grandmother = 'Helen';
- Grandmother = 'Ruth' ;

 Who are the grandchildren of Paul and Helen?
  grandfather_of('Paul', GrandChild), grandmother_of('Helen', GrandChild).
-  GrandChild = 'Dudley' ;
-  GrandChild = 'Harry' ;


 Does James have a sister?
  sister_of(Sister, 'James').
 - false

 Aunt of Harry
    aunt_of(X,'Harry').
  - X = 'Petunia'



 Is Albert an ancestor of Harry?
  ancestor_of('Albert', 'Harry').
 - true

Who are the ancestors of Harry?
 - ancestor_of(Ancestor, 'Harry').
 - Ancestor = 'James' ;
 - Ancestor = 'Lili' ;
 - Ancestor = 'Paul' ;
 - Ancestor = 'Helen' ;
 - Ancestor = 'Albert' ;
 -  Ancestor = 'Ruth'


Is Dudley an ancestor of Harry?
   ancestor_of('Dudley', 'Harry').
  - false

Who are the descendants of James?
  ancestor_of('James', Descendant).
  - Descendant = 'Harry'

  Is Dudley a parent of Harry?
  not_parent('Dudley', 'Harry').
  -true


*/
