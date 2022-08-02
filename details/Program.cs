using details;
product product = new product();
Details details = new Details("black",50,5);
product.name = "laptop";
product.id = 100;
product.details = details;

Console.WriteLine($"product id : {product.id}\t product name : {product.name}\t product details: {product.details.color}\t{product.details.size}\t{product.details.weight}");