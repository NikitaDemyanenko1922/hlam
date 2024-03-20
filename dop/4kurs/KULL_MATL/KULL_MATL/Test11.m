function tt=Test11(x)
a=1;
gr = 10000;
fun = @(alpha)((pi.*alpha).*(-exp(1i.*alpha.^2)+exp(-1i*alpha.^2)))./((log(exp(x)).^2).*alpha.^4-pi.^2).*(exp(-(-1i).*alpha.*x));
tt = integral(fun,-gr,gr);
end