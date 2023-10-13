% найти сумму всех делителей числа,
% взаимно простых с суммой цифр числа
% и не взаимно простых с произведением цифр числа

summa_del(N,A):-summa_del(N,A,0).
summa_del(0,A,A).
summa_del(N,A,S):-
	N=>S,
	N =:= S -> summa_del(0,A,S);
		S is S + 1,
		N mod S =:= 0 -> A is A + S,
		summa_del(N,A,S).

% ńóěěa öčôđ ÷čńëŕ
sum_num(N,A):-sum_num(N,A,0).
sum_num(0,A,A).
sum_num(N,A,S):-
    N>0,
    N1 is N mod 10,
    N2 is N // 10,
    S1 is S + N1,
    sum_num(N2,A,S1).

% ďđîčçâĺäĺíčĺ öčôđ ÷čńëŕ
prod_num(N,A):- prod_num(N,A,1).
prod_num(0,A,A).
prod_num(N,A,S):-
    N>0,
    N1 is N mod 10,
    N2 is N // 10,
    S1 is S * N1,
    prod_num(N2,A,S1).

% N1%UYA ne pon'yatno
divisor_num(X,A):-
    divisor_num(X,A,1,1).
divisor_num(0,A,A,1).
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

div_n(X,A):-
    div_n(X,A,1).
div_n(0,A,A).
div_n(X,A,N):-
   X > 0,
   N =< X,
   N1 is N+1,
   X1 is X mod N1,
   X1 =:= 0 ->
    X2 is X // N1;
    X2 is X,
   div_n(X2,A,N1).

