function funk=K(al)
z=-0.5;
b=64;
funk =(sinh(sqrt(al.^2-b).*(z+1))./(sqrt(al.^2-b).*cosh(sqrt(al.^2-b))));
end
