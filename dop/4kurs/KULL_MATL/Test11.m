function tt=Test11(x)
a=1;
gr = 10000;
fun = @(alfa) -2.*a.*(exp((2.*1i).*a.*alfa).*pi + pi).*exp((-1*1i).*a.*alfa)./(4.*a.*a.*alfa.*alfa - pi.*pi).*exp(-(-1i).*alfa.*x);
tt = integral(fun,-gr,gr);
end