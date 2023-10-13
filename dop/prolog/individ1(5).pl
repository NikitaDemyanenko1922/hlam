% naiti summu vseh deliteley chisla,
% vzaimno prostyh s summoi cifr chisel  
% i ne vzaimno prostyh s proizved cifr cisla

% summa cifr v chisle
sum_num(N,A):-sum_num(N,A,0).
sum_num(0,A,A):- !.
sum_num(N,A,S):-
    N>0,
    N1 is N mod 10,
    N2 is N // 10,
    S1 is S + N1,
    sum_num(N2,A,S1).

% proizved cifr v chisle
prod_num(N,A):- prod_num(N,A,1).
prod_num(0,A,A):- !.
prod_num(N,A,S):-
    N>0,
    N1 is N mod 10,
    N2 is N // 10,
    S1 is S * N1,
    prod_num(N2,A,S1).

%summa vseh delitiley
div_sum(Value, Sum):-div_sum(1, Value, Value, Sum).
div_sum(I, N, _Value, Sum):-
    I >= N, !, Sum is 0.
div_sum(I, N, Value, Sum):-
    0 is Value mod I, !,
    NextI is I + 1,
    div_sum(NextI, N, Value, TailSum),
    Sum is TailSum + I.
div_sum(I, N, Value, Sum):-
    NextI is I + 1,
    div_sum(NextI, N, Value, TailSum),
    Sum is TailSum.

%summa vseh delitiley po zadaniyu
zadacha_div_sum(Value, Sum):-zadacha_div_sum(1, Value, Value, Sum).
zadacha_div_sum(I, N, _Value, Sum):-
    I >= N, !, Sum is 0.
zadacha_div_sum(I, N, Value, Sum):-
    0 is Value mod I, !,
    NextI is I + 1,
    zadacha_div_sum(NextI, N, Value, TailSum),
    Sum is TailSum + I.
zadacha_div_sum(I, N, Value, Sum):-
    NextI is I + 1,
    zadacha_div_sum(NextI, N, Value, TailSum),
    Sum is TailSum.

co_primes(A, B, Answer):- gcd(A, B, 1).

gcd(0, B, B):- !.
gcd(A, 0, A):- !.
gcd(0, B, 1):- !. %sdelat vivod false
gcd(A, 0, 1):- !. %sdelat vivod false 32476349826y4378t87egpiruhgpuifbh

gcd(A, B, X):- A >= B, M is A mod B, gcd(M, B, X).
gcd(A, B, X):- A < B, M is B mod A, gcd(A, M, X).









% N1cheugo ne ponyatno
divisor_num(X,A):- divisor_num(X,A,1,1).
divisor_num(0,A,A,1):- !.
divisor_num(X,A,N,F):-
   X > 0,
   N =< X,
   N1 is N+1,
   X1 is X mod N1,
  (X1 =:= 0 ->
    X2 is X // N1,
    F1 is 1;
    X2 is X,
    F1 is 0),
   divisor_num(X2,A,N1,F1).