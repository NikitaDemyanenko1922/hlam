function tt=Test1(x)
a=1;
gr = 100;
fun = @(alfa) (1/(pi)).*(2*pi.*alfa.*(exp(2.*1i.*a.*alfa)+1).*exp(-1i.*a.*alfa))./(-4.*a.*a.*alfa.*alfa+pi.*pi).*exp((-1i).*alfa.*x);
tt = integral(fun,-gr,gr);
end