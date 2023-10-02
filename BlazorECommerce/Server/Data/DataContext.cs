

namespace BlazorECommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Samsung Galaxy S III",
                    Description = "The Samsung Galaxy S III (unofficially known as the Samsung Galaxy S3) is an Android smartphone designed, developed, and marketed by Samsung Electronics. Launched in 2012, it had sold more than 80 million units overall, making it the most sold phone in the S series.[5] It is the third smartphone in the Samsung Galaxy S series.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Samsung_Galaxy_S_III.png",
                    Price = 9.99m
                },
        new Product
        {
            Id = 2,
            Title = "Nokia N8",
            Description = "The Nokia N8 is a touchscreen-based smartphone developed by Nokia. Announced on 27 April 2010, the Nokia N8 was the first device to run on the Symbian^3 mobile operating system and it was the company's flagship device for the year.[4] It was released on 30 September 2010 at the Nokia Online Store before being released in markets around the world on 1 October 2010.[5] There were two version made, the N8 and the N8-00. The N8 was made for Vodafone and locked to its networks,[6] and the N8-00 was made by Microsoft and open network.",
            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Nokia_N8.png",
            Price = 6.99m
        },
        new Product
        {
            Id = 3,
            Title = "iPhone X",
            Description = "The iPhone X (Roman numeral X pronounced ten [12]) is a smartphone designed, developed and marketed by Apple Inc. It is part of the eleventh generation of the iPhone. Available for pre-order from October 27, 2017, it was released on November 3, 2017. The naming of the iPhone X (skipping the iPhone 9) is to mark the 10th anniversary of the iPhone.",
            Image = "https://upload.wikimedia.org/wikipedia/commons/3/32/IPhone_X_vector.svg",
            Price = 4.99m
        }
                );
        }
    }
}
