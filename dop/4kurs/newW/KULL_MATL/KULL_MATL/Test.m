clear; clc;
x = linspace(-10, 10, 50);
y(1:length(x))=0;
for i=1:length(x)
    y(i) = Test1(x(i));
end
figure;
plot(x,abs(y)/(2*pi));

hold on;
y(1:length(x))=0;
for i=1:length(x)
    y(i) = Test11(x(i));
end
plot(x,abs(y)/(2*pi),'-g');

hold on;
y1(1:length(x))=0;
for i=1:length(x)
    y1(i) = Test2(x(i));
end
plot(x,abs(y1),'-r');
hold off;