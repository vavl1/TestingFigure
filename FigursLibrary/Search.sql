select products.Name,categories.Name
from Products
 join  ProductToCategories on Products.Id = ProductToCategories.ProductId
 join Categories on Categories.Id = ProductToCategories.CategoryId