clear; clc;
x = linspace(0, 7, 50);
y(1:length(x))=0;

for i=1:length(x)
    y(i) = Untitled3(x(i));
end
figure;
plot(x,y);

hold on;
y(1:length(x))=0;
for i=1:length(x)
    y(i) = Untitled5(x(i));
end
plot(x,y,'r--');
hold off;
