s(s(NpT,VpT)) --> np(NpT), vp(VpT).
np(np(DetT,NT)) --> det(DetT), n(NT).
np(np(PnT)) --> pn(PnT).
vp(vp(ViT)) --> vi(ViT).
vp(vp(VtT,NpT)) --> vt(VtT), np(NpT).
%% Lexicon
det(det(a)) --> [a].
det(det(the)) --> [the].
n(n(bride)) --> [bride].
n(n(nurse)) --> [nurse].
n(n(yakuza)) --> [yakuza].
n(n(whiskey)) --> [whiskey].
pn(pn(bill)) --> [bill].
pn(pn(gogo)) --> [gogo].
vi(vi(whistles)) --> [whistles].
vi(vi(fights)) --> [fights].
vt(vt(drinks)) --> [drinks].
vt(vt(kills)) --> [kills].


/*
?- s(A, [the,nurse,whistles], C).
A = s(np(det(the), n(nurse)), vp(vi(whistles))),
C = [] ;
false.
*/
