s --> np(subj), vp.

np(subj) --> article(Case), n(Case).
np(obj) --> article2(Case), n(Case).
np(obj2) --> article3(Case), n(Case).
np(_) --> pn.
np(Case) --> pro(Case).

vp --> vi.
vp --> vt, np(obj).
vp --> vd, np(obj2), np(obj).


%% Lexicon

article(male) --> [der].
article(female) --> [die].
article(thing) --> [das].

article2(male) --> [den].
article2(female) --> [die].
article2(thing) --> [das].

article3(male) --> [dem].
article3(female) --> [der].
article3(thing) --> [dem].


n(male) --> [herr].
n(thing) --> [maedel].
n(female) --> [frau].
n(thing) --> [kind].
n(thing) --> [auto].



pn --> [bill].
pn --> [tom].
pn --> [luca].
pn --> [gagan].

pro(subj) --> [er].
pro(subj) --> [sie].
pro(obj) --> [ihn].
pro(obj) --> [sie].
pro(obj2) --> [ihm].
pro(obj2) --> [ihr].

vi --> [kackt].
vi --> [isst].

vt --> [faehrt].
vt --> [traegt].

vd --> [gibt].
