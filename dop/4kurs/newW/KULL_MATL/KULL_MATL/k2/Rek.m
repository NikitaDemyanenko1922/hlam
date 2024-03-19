function rek=Rek(x,gr1,gr2)
a=1;
fun = @(al) ((K(al).*Fun(a,al)).*exp(-1i.*(x.*al))+(K(-al).*Fun(a,-al)).*exp(1i.*(x.*al)));
rek= integral(fun, gr1,gr2);
end
