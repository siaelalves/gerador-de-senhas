Public Class GEN
    ''' <summary>
    ''' Lista os valores de complexidade para a senha.
    ''' </summary>
    Enum Complexidade As Integer
        Símbolos = 1
        Letras_maiúsculas = 2
        Letras_minúsculas = 4
        Números = 8
    End Enum
    ''' <summary>
    ''' Retorna um caractere aleatoriamente conforme os requisitos
    ''' de complexidade
    ''' </summary>
    ''' <returns></returns>
    ''' <param name="CaractereInicial" >Primeiro caractere da sequência ASCII de símbolos.</param>
    ''' <param name="CaractereFinal" >Último caractere da sequência ASCII de símbolos.</param>
    ''' <remarks></remarks>
    Public Overloads Function GerarCaractereAleatório(ByVal CaractereInicial As Char, CaractereFinal As Char) As String
        Return Chr(Int(Asc(CaractereFinal) - Asc(CaractereInicial) + 1) * Rnd() + Asc(CaractereInicial))
    End Function

End Class
