Console.Write("Please Insert Number Of Small Carpets : ");
double smallCarpet = Convert.ToDouble(Console.ReadLine());
Console.Write("Please Insert Number Of Large Carpets : ");
double largeCarpet = Convert.ToDouble(Console.ReadLine());
double smallPrice = Convert.ToDouble(25);
Console.WriteLine($"Price Per Small Carpet :${smallPrice}");
double largePrice = Convert.ToDouble(35);
Console.WriteLine($"Price Per Large Carpet :${largePrice}");
double Cost = (smallCarpet * smallPrice) + (largeCarpet * largePrice);
Console.WriteLine($"Cost :${Cost}");
double Tax = Cost *.06;
Console.WriteLine($"Tax :${Tax}");
Console.WriteLine("=============================");
decimal totalEstimate = Convert.ToDecimal(Cost) + Convert.ToDecimal(Tax);
Console.WriteLine($"Total estimate : ${totalEstimate}");
Console.WriteLine("this Estimate is Valid For 30 Day");




