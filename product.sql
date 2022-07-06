SELECT * FROM Products 
LEFT JOIN ProductsToCategories 
ON Prod.Id = ProductsToCategories.ProdId 
LEFT JOIN Categories 
ON Categories.Id = ProductsToCategories.CatId