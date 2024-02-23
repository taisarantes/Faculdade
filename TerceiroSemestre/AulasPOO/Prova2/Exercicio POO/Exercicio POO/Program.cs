using Exercicio_POO;

Loja loja = new Loja();

Gerente gojo = new Gerente("Gojo");
Vendedor yuji = new Vendedor("Yuji");

Automovel compacto = new Automovel("fox", "wolkswagen", "preto", 150000, "comapacto", "airbag");
Automovel sedan = new Automovel("palio", "a", "cinza", 150000, "sedan", "airbag");
Automovel suv = new Automovel("carlos", "wolkswagen", "verde", 150000, "suv", "airbag");
Automovel picape = new Automovel("ivete", "wolkswagen", "branco", 150000, "picape", "airbag");

Motocicleta street = new Motocicleta("roberta", "seila", "vermelha", 30000, "street", "amortecedor");
Motocicleta custom = new Motocicleta("adera", "totoro", "azul", 30000, "custom", "amortecedor");

loja.adicionarVeiculo(compacto, gojo);
loja.adicionarVeiculo(sedan, gojo);
loja.adicionarVeiculo(suv, gojo);
loja.adicionarVeiculo(picape, gojo);
loja.adicionarVeiculo(street, gojo);
loja.adicionarVeiculo(custom, yuji);

Console.WriteLine(suv.Descricao());
Console.WriteLine(custom.Descricao());

Console.WriteLine("--------------------");
Console.WriteLine("Veiculos na loja:");
loja.listarVeiculos(loja.listaVeiculos);

loja.venderVeiculo(street, yuji);
loja.venderVeiculo(sedan, gojo);

Console.WriteLine("--------------------");
Console.WriteLine("Veiculos na loja depois de um dia de venda:");
loja.listarVeiculos(loja.listaVeiculos);