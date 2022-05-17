// See https://aka.ms/new-console-template for more information
LineComparision.Line linecomparison = new LineComparision.Line();
double length1 = linecomparison.getLength(4, 6, 8, 6);
double length2 = linecomparison.getLength(3, 7, 5, 7);
double length3 = linecomparison.getLength(3, 7, 15, 7);
Console.WriteLine("length of line1 = {0}",length1);
Console.WriteLine("length of line2 = {0}",length2);
Console.WriteLine("length of line3 = {0}",length3);
if (length1 == length2)
{
    Console.WriteLine("Lengths are Equal");
}
else
{
    Console.WriteLine("Lengths are not equal");
}
LineComparision.Compare lengthcomparison = new LineComparision.Compare();
lengthcomparison.CompareLength(length1,length2);