using DesignPatterns2.Cap_2;

NotasMusicais notas = new NotasMusicais();
IList<INota> musica = new List<INota>()
{
    notas.Pega("do"),
    notas.Pega("re"),
    notas.Pega("mi"),
    notas.Pega("fa"),
    notas.Pega("fa"),
    notas.Pega("fa"),

};
Piano piano = new Piano();
piano.Toca(musica);