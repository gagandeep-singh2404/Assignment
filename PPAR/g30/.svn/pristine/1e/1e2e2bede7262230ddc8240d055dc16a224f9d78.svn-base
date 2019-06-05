
xor([],[],[]).

xor([PH|PT],[KH|KT],[CH|CT]):- PH == KH -> CH = 0,xor(PT,KT,CT), !.
xor([PH|PT],[KH|KT],[CH|CT]):- PH \= KH -> CH = 1 ,xor(PT,KT,CT), !.


/*
 - xor([0,0,0],[0,1,0],Z).
 - z = [0,1,0].


 xor([1,1],[0,1],Z), xor(Z,[0,1],Y).
  Z = [1, 0],
  Y = [1, 1].
 */

substitute(Normal,Encoded):- char_code(Normal, A), TempNormal is  A+1, char_code(Encoded,TempNormal).
endSubstitute(Encoded, Normal) :- char_code(Encoded, B), TempDecoded is B-1, char_code(Normal,TempDecoded).

encode([],[]).
encode([PH|PT],[EH|ET]) :- substitute(PH,EH),encode(PT,ET), !.

decode([],[]).
decode([EH|ET],[PH|PT]) :- endSubstitute(EH,PH) ,decode(ET,PT), !.

/*
 encode([a,a,a],X).
 - X = [b, b, b].

  decode([b,b,b],Y).
- Y = [a, a, a].

*/
