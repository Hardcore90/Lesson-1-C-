// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool F(bool X, bool Y)
{
    return (!(X || Y) == ((!X) && (!Y)));
}
Console.WriteLine(F(false,false));