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


/*** Is Lavender to the right of Parvati?
* sits_right_of('Lavander Brown', 'Parvati Patil').
* false
***/

/*** Is Lavender to the right of Neville?
* sits_right_of('Lavander Brown', 'Neville Longbottom').
* true
***/

/*** Who is to the right of Hermione?
* sits_right_of('Lavander Brown', X).
* X = 'Neville Longbottom'.
***/

/*** Who is sitting at the table?
* findall(X, sits_right_of(X, Y), Z), write(Z).
* [Katie Bell,Parvati Patil,Lavander Brown,Neville Longbottom,Alicia Spinnet,Fred Weasley,George Weasley,Lee Jordan,Dennis Creevey,Dean Thomas,Ginny Weasley,Angelina Johnson,Seamus Finnigan,Colin Creevey,Harry Potter,Hermione Granger,Ron Weasley,Natalie McDonald]
* Z = ['Katie Bell', 'Parvati Patil', 'Lavander Brown', 'Neville Longbottom', 'Alicia Spinnet', 'Fred Weasley', 'George Weasley', 'Lee Jordan', 'Dennis Creevey'|...].
***/

/*** Who is sitting two seats to the right of Hermione?
* sits_right_of('Hermione Granger', X), sits_right_of(X, Y).
* X = 'Ron Weasley',
* Y = 'Natalie McDonald'.
***/

/*** Who is sitting between Neville and Fred?
*  are_neighbors_of('Neville Longbottom', 'Fred Weasley', X).
*  X = 'Alicia Spinnet'.
***/










