function fun=Fun1(a,al)
fv = 2.*al.*a.*(2-(1i).*al).*cos(al.*a);
fn = al.*al.*al;
fun = fv/fn;
end