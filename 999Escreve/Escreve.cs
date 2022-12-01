namespace Escreve
{
    public void Escreve() {

    [Fact]
     void TestName()
    {
        // Given
    
        // When
    
        // Then
    }
    Stack<int> pilha = new Stack<int>();
        for (var i = 0; i < 5; ++i)
            {
            pilha.Push(i);
            }
        while (pilha.Count > 0)
        {
        Console.WriteLine(pilha.Pop());
    }
}
}