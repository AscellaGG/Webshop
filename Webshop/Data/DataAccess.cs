using Webshop.Components;

namespace Webshop.Data;

public class DataAccess
{
	private readonly List<Product> _products = [];
	private List<CartItem> _cartItems = [];

	public int NextItemId => _products.Count.Equals(0) ? 1 : _products.Max(p => p.Id) + 1;

	public DataAccess()
	{
        _products.Add(new Product { Id = NextItemId, ProductName = "The Tortured Poets Department", Price = 215f, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/6e/Taylor_Swift_%E2%80%93_The_Tortured_Poets_Department_%28album_cover%29.png/220px-Taylor_Swift_%E2%80%93_The_Tortured_Poets_Department_%28album_cover%29.png" });
        _products.Add(new Product{ Id = NextItemId, ProductName = "1989 (Taylor's Version)", Price = 215f, ImgUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Taylor_Swift_-_1989_%28Taylor%27s_Version%29.png" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Midnights", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2022/10/taylor-swift-midnights-album-cover-2022-billboard-1240.jpg?w=1024" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Fearless (Taylor's Version)", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2021/04/Taylor-Swift-fearless-album-art-cr-Beth-Garrabrant-billboard-1240-1617974663.jpg?w=1024" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Folklore", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2020/12/Taylor-swift-folklore-cover-billboard-1240-1607121703.jpg?w=1024" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Speak Now (Taylor's Version)", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2023/05/Speak-Now-Taylors-Version-billboard-1240.jpg?w=1024" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Evermore", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2020/12/taylor-swift-cover-2020-billboard-1240-1607612466.jpg?w=1024" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Lover", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/media/Taylor-Swift-Lover-album-art-2019-billboard-1240.jpg?w=768" });
		_products.Add(new Product{ Id = NextItemId, ProductName = "Red (Taylor's Version)", Price = 215f, ImgUrl = "https://www.billboard.com/wp-content/uploads/2022/10/taylor-swift-red-taylors-version-billboard-1240.jpg?w=768" });
	}

	public List<Product> GetProducts() { return _products; }

	public List<CartItem> GetCart() { return _cartItems; }

	public void SetCart(List<CartItem> cartItems)
	{
		_cartItems = cartItems;
	}

	public void AddToCart(CartItem item)
	{
		if(_cartItems.Any(i => i.Product.Id == item.Product.Id))
		{
			_cartItems.Find(i => i.Product.Id == item.Product.Id).Quantity += 1;
		}
		else
        {
            _cartItems.Add(item);
        }
	}

	public Product GetProductById(int id)
	{
		return _products.Find(p => p.Id == id);
	}

	public int GetCartSize()
	{
		int size = 0;
		foreach (var item in _cartItems)
		{
			size += item.Quantity;
		}

		return size;
	}

}


