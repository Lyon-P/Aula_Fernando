using Rodrigo_Sem_Fatos;

string[] N_M = new string[] {
"Rodrigo",
"João",
"Lucas",
"Leonardo",
"Walison",
"Andrew",
"Gustavo",
"Giovanni",
"Sandro",
"Walter",
"Silvio",
"Gabriel",
"Matheus",
"Vinicius",
"Genisvaldo",
"Kauãn",
"Sanderley",
"Eduardo",
"Raul",
};

string[] N_F = new string[] {
"Zulbeide",
"Samira",
"Patricia",
"Ana",
"Madalena",
"Josefina",
"Rosmari",
"Karol",
"Eduarda",
"Maria",
"Joana",
"Benedita",
"Suzy",
"Santina",
"Joyce",
"Helena",
"Amanda",
"Thaisa",
"Marina",
};

string[] S = new string[] {
"de Paula",
"Ferreira",
"da Cruz",
"Pinto",
"de Jesus",
"Sanflorian",
"Ferioli",
"Fring",
"Boaro",
"Barretos",
"Coelho",
"Xavier",
"Johnson",
"Pingola",
"Dynasty",
"Henrique",
"Silva",
"Santos",
"Batista",
};

string[] S2 = new string[] {
"",
"Newton",
"Izaki",
"Seixas",
"Okada",
"Valdisney",
"Valinn",
"Lopes",
"Marcondez",
"Walker",
"Miller",
"Oliveira",
"Marchesan",
"Sanchez",
"Rocha",
"Scabello",
"Tosta",
"Okida",
"Justus",
"Motta",
"",
};


Bimgoula p4 = new Bimgoula();
p4.Desc = "Marmitexx";
p4.Val = 10;
p4.id = 1;

Bimgoula p5 = new Bimgoula();
p5.Desc = "Chuchu";
p5.Val = 2.9;
p5.id = 2;

Bimgoula p6 = new Bimgoula();
p6.Desc = "Goiabadis";
p6.Val = 4.2;
p6.id = 3;

Bimgoula p7 = new Bimgoula();
p7.Desc = "Carne seca seca";
p7.Val = 8.4;
p7.id = 4;

Bimgoula p8 = new Bimgoula();
p8.Desc = "Leite de craba";
p8.Val = 4.5;
p8.id = 5;

Bimgoula p9 = new Bimgoula();
p9.Desc = "Sopa de letrinhas bunitinhas inhas inhas";
p9.Val = 2.99;
p9.id = 6;

/*
for (int i = 1; i <= 576; ++i)
{
    Random Aleatorio = new Random();

    Bimgoula p = new Bimgoula();
    p.Desc = "Produto_"+i;
    p.Val = Math.Round(i + Aleatorio.NextDouble() + Aleatorio.Next(1,1000),2);
    p.id = i;
    Console.WriteLine("Descrição do Produto =   "+p.Desc+"\nPreço =   "+p.Val+"\nID =   "+p.id+"\n\n");
}
*/
int M_F = 0; // Variável de controle.
for (int i = 1; i <= 5000; ++i){
    Random Gerar_V_A = new Random();
    M_F = Gerar_V_A.Next(0, 2);

    People Pessoa = new People();
    Pessoa.CPF = Gerar_V_A.Next(100, 999)+"."+ Gerar_V_A.Next(100, 999)+"."+Gerar_V_A.Next(100, 999)+"-"+ Gerar_V_A.Next(0, 99);
    Pessoa.Idade = Gerar_V_A.Next(18, 100);
    if (M_F <= 0) { M_F = Gerar_V_A.Next(1, N_M.Length); Pessoa.Nome = N_M[M_F] + " "; M_F = Gerar_V_A.Next(1, S.Length); Pessoa.Nome = Pessoa.Nome + S[M_F]; M_F = Gerar_V_A.Next(1, S2.Length); Pessoa.Nome = Pessoa.Nome + " " + S2[M_F]; } else { M_F = Gerar_V_A.Next(1, N_F.Length); Pessoa.Nome = N_F[M_F] + " "; M_F = Gerar_V_A.Next(1, S.Length); Pessoa.Nome = Pessoa.Nome + S[M_F]; M_F = Gerar_V_A.Next(1, S2.Length); Pessoa.Nome = Pessoa.Nome + " " + S2[M_F]; }
    //Pessoa.Nome = +i+"-"+(Math.Round(Gerar_V_A.NextDouble() * (Gerar_V_A.Next(100, 200)),2));
    Console.WriteLine("- Registro = " + i + "\n#CPF =   " + Pessoa.CPF + "\n#Idade =   " + Pessoa.Idade + "\n#Nome =   " + Pessoa.Nome + "\n\n");
} return 0;