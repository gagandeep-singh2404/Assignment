sits_right_of(dean,ginny).
sits_right_of(ginny,angelina).
sits_right_of(angelina,seamus).
sits_right_of(seamus,colin).
sits_right_of(colin,harry).
sits_right_of(harry,hermione).
sits_right_of(hermione,ron).
sits_right_of(ron,natalie).
sits_right_of(natalie,katie).
sits_right_of(katie,parvati).
sits_right_of(parvati,lavender).
sits_right_of(lavender,neville).
sits_right_of(neville,alicia).
sits_right_of(alicia,fred).
sits_right_of(fred,george).
sits_right_of(george,lee).
sits_right_of(lee,dennis).
sits_right_of(dennis,dean).


sits_left_of(Y, X) :-
sits_right_of(X, Y).


are_neighbors_of(X,Z,Y) :- sits_left_of(X,Z) ,sits_right_of(Y,Z).


next_to_each_other(X,Y) :- sits_left_of(X,Y) ; sits_left_of(X,Y).


/* Is Lavender to the right of Parvati?
 sits_right_of('lavender', 'parvati').
 false


Is Lavender to the right of Neville?
 sits_right_of('lavender', 'neville').
 true


 Who is to the right of Hermione?
 sits_right_of(X,'hermione').
X = harry.




    Who is sitting on the table ?
?- sits_right_of(X,Y).
X = dean, Y = ginny ;
X = ginny, Y = angelina ;
X = angelina, Y = seamus ;
X = seamus, Y = colin ;
X = colin, Y = harry ;
X = harry,Y = hermione ;
X = hermione,Y = ron ;
X = ron,Y = natalie ;
X = natalie,Y = katie ;
X = katie,Y = parvati ;
X = parvati,Y = lavender ;
X = lavender,Y = neville ;
X = neville,Y = alicia ;
X = alicia,Y = fred ;
X = fred,Y = george ;
X = george,Y = lee ;
X = lee,Y = dennis ;
X = dennis,Y = dean.

?- are_neighbors_of('hermione',Y,Z).
Y = harry,
Z = colin. True

 Who is sitting between Neville and Fred?
?- are_neighbors_of('fred',Y,'neville').
Y = alicia.
*/










