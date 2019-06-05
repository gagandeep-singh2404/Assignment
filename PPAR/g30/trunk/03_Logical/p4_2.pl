/* Day 4, Assignment 2 */

s(s(NPT,VPT)) --> npsubj(NPT), vp(VPT).

npsubj(npsubj(DetT, NT)) --> articlemale(DetT), nmale(NT).
npsubj(npsubj(DetT, NT)) --> articlefemale(DetT), nfemale(NT).
npsubj(npsubj(DetT, NT)) --> articleThing(DetT), nthing(NT).
npsubj(npsubj(PNT)) --> pn(PNT).
npsubj(npsubj(PRT)) --> prosubj(PRT).
npobj(npobj(DetT, NT)) --> article2male(DetT), nmale(NT).
npobj(npobj(DetT, NT)) --> article2female(DetT), nfemale(NT).
npobj(npobj(DetT, NT)) --> article2thing(DetT), nthing(NT).
npobj(npobj(PNT)) --> pn(PNT).
npobj(npobj(PRT)) --> proobj(PRT).

vp(vp(ViT)) --> vi(ViT).
vp(vp(VtT,NPT)) --> vt(VtT), npobj(NPT).

%% Lexicon
nmale(nmale(mann)) --> [mann].
nfemale(nfemale(frau)) --> [frau].
nthing(nthing(auto)) --> [auto].
articlemale(articlemale(der)) --> [der].
articlefemale(articlefemale(die)) --> [die].
articleThing(articleThing(das)) --> [das].
article2male(article2male(den)) --> [den].
article2female(article2female(die)) --> [die].
article2thing(article2thing(das)) --> [das].
pn(pn(peter)) --> [peter].
prosubj(prosubj(er)) --> [er].
prosubj(prosubj(sie)) --> [sie].
proobj(proobj(ihn)) --> [ihn].
proobj(proobj(sie)) --> [sie].
vi(vi(schwimmt)) --> [schwimmt].
vi(vi(singt)) --> [singt].
vt(vt(faehrt)) --> [faehrt].
vt(vt(fragt)) --> [fragt].


/*

?- s(X,S,[]).
X = s(npsubj(articlemale(der), nmale(mann)), vp(vi(schwimmt))),
S = [der, mann, schwimmt] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vi(singt))),
S = [der, mann, singt] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(article2male(den), nmale(mann)))),
S = [der, mann, faehrt, den, mann] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(article2female(die), nfemale(frau)))),
S = [der, mann, faehrt, die, frau] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(article2thing(das), nthing(auto)))),
S = [der, mann, faehrt, das, auto] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(pn(peter)))),
S = [der, mann, faehrt, peter] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(proobj(ihn)))),
S = [der, mann, faehrt, ihn] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(faehrt), npobj(proobj(sie)))),
S = [der, mann, faehrt, sie] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(article2male(den), nmale(mann)))),
S = [der, mann, fragt, den, mann] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(article2female(die), nfemale(frau)))),
S = [der, mann, fragt, die, frau] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(article2thing(das), nthing(auto)))),
S = [der, mann, fragt, das, auto] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(pn(peter)))),
S = [der, mann, fragt, peter] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(proobj(ihn)))),
S = [der, mann, fragt, ihn] ;
X = s(npsubj(articlemale(der), nmale(mann)), vp(vt(fragt), npobj(proobj(sie)))),
S = [der, mann, fragt, sie] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vi(schwimmt))),
S = [die, frau, schwimmt] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vi(singt))),
S = [die, frau, singt] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vt(faehrt), npobj(article2male(den), nmale(mann)))),
S = [die, frau, faehrt, den, mann] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vt(faehrt), npobj(article2female(die), nfemale(frau)))),
S = [die, frau, faehrt, die, frau] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vt(faehrt), npobj(article2thing(das), nthing(auto)))),
S = [die, frau, faehrt, das, auto] ;
X = s(npsubj(articlefemale(die), nfemale(frau)), vp(vt(faehrt), npobj(pn(peter)))),
S = [die, frau, faehrt, peter] 


*/
