// функция Аккермана, задача 68
static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
uint res1;
res1 = A(2, 3); //res1 = 9
uint res2;
res2 = A(3, 2); //res2 = 29
Console.WriteLine(res1);
Console.WriteLine(res2);