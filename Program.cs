int glicose;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(">>>>>DIABETES GESTACIONAL<<<<<");
Console.ResetColor();

Console.Write("Digite a quantidade de mg/dL:");
glicose = Convert.ToInt32(Console.ReadLine());

if (glicose >126)
{
    Console.WriteLine("Diabetes Mellitus na Gravidez");
}

else
{
   if (glicose >=92)
   {
      Console.WriteLine("Compatível Diabetes Gestacional");
   }

   else
   {
    Console.WriteLine("reavaliar entre 24 e 28 semanas com TTOG 75g de glicose");
   }
}