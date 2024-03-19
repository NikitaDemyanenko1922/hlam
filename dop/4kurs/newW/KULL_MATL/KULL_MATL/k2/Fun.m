function fun=Fun(a,al)
fv11 = ((1i).*a.*a+(1i).*a).*al.*al;
fv12 = (-2.*a-1).*al-2.*(1i);
fn1 = al.*al.*al;
fun1 = ((fv11+fv12).*exp((1i).*a.*al))./fn1;
fv2 = (1i).*a-(1i).*a.*a;
fn2 = al.*exp((1i).*a.*al);
fun2 = fv2./fn2;
fv3 = 1-2.*a;
fn3 = al.*al.*exp((1i).*a.*al);
fun3 = fv3./fn3;
fun4 = (2.*(1i))./(fn1.*exp((1i).*a.*al));
fun = -fun1-fun2-fun3-fun4;
end