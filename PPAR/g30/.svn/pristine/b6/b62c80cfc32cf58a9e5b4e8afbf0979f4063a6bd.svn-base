
all_as(List) :-
  not(length(List, 0)),
  member(X, List),
  X \= a -> false; true.

  /*
    all_as([a,a]).
   - true

    all_as([a,b]).
   - false

   all_as([]).
   - false
   */

   list_length([],0).
   list_length([_|T], L) :-
    list_length(T,X),
    L is X +1.


/*
  list_length([a,a,b,b,c,c,d,d], X).
 - X = 8.

  list_length([11,1,1,1,1,1,1,1,21,21,21,21,21,2,3,31,2,1,21,2,3,1,2,12,12,1,21,2,1], X).
  X = 29.

  list_length([], X).
  X = 0.
 */

 replace([],[]).
replace([H1|T1], [H2|T2]):- H1 == u -> H2 = i, replace(T1, T2),!.
replace([H1|T1], [H2|T2]):- H1 == i -> H2 = o, replace(T1, T2),!.
replace([H1|T1], [H2|T2]):- H1 == o -> H2 = u, replace(T1, T2),!.
replace([H1|T1], [H2|T2]):- H1 = H2, replace(T1, T2).


/*
  replace([u,i,o], X).
  X = [i, o, u].
  
  replace([u,a,i], X).
  X = [i, a, o].
 */
