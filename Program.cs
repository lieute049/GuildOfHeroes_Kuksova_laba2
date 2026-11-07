Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");
yaroslav.TakeDamage(25);
anastasia.TakeDamage(30);
Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}")
;