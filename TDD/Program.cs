// See https://aka.ms/new-console-template for more information
using TDD;




try
{

    Library L  = new Library();
    L.addBooksFromFile();
    L.Sort();
    Console.WriteLine(L);

   




}catch(Exception e)
{
    Console.WriteLine(e.ToString());
}

