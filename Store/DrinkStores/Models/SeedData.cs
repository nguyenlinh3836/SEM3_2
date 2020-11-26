using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    //Id, Name, Description, Img, Price, Discount, Status
                    new Product
                    {
                        Name = "Trà phô mai kem sữa",
                        Description = " Một món nước uống vừa béo ngậy, chua ngọt đủ cả mà vẫn có vị thanh của trà",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/tra-pho-mai-kem-sua(1).jpg",
                        Price = 50,
                        Category = "Trà",
                        Discount = 35
                    },
                    new Product
                    {
                        Name = "Cafe-latte",
                        Description = "Cafe latte được tạo hình một cách nghệ thuật, độc đáo",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/cafe-latte(1).jpg",
                        Price = 60,
                        Category = "Cà phê",
                        Discount = 45
                    },
                    new Product
                    {
                        Name = "Ca-cao",
                        Description = "Cacao không chỉ ngon mà còn rất bổ dưỡng, cacao giàu protein, chứa nhiều axit béo",
                        Img= "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/ca-cao(1).jpg",
                        Price = 35,
                        Category = "Nước",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Trà sữa chân trâu đường đen",
                        Description = "Neutral grain spirit.NOT to be drunk neat.",
                        Img = "Món đồ uống này không hề có các nguyên liệu cầu kỳ mà chỉ là vị sữa thơm ngậy, trân châu giòn ngon ngấm vị đường" +
                        " đen ngọt lịm, tạo nên mùi vị thơm béo mà không hề ngấy.",
                        Price = 40,
                        Category = "Trà",
                        Discount = 30
                    },
                    new Product
                    {
                        Name = "Sinh tố",
                        Description = "Sinh tố là món nước uống được pha chế từ các loại trái cây tươi, đá và nước ép trái cây hoặc sirô để lạnh",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/sinh-to(1).jpg",
                        Price = 30,
                        Category = "Nước",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Socola đá việt quất",
                        Description = "Soda việt quất với màu sắc bắt mắt cùng hương vị tuyệt vời",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/so-da-viet-quat.jpg",
                        Price = 42,
                        Category = "Nước",
                        Discount = 35
                    },
                    new Product
                    {
                        Name = "Trà hoa quả",
                        Description = "Vị chua, vị ngọt của hoa quả hòa quyện với vị chan chát của trà sẽ mang đến những cảm giác sảng khoái cho ngày hè oi bức.",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/tra-hoa-qua.jpg",
                        Price = 25,
                        Category = "Trà",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Matcha đá xay",
                        Description = "Matcha đá xay có vị hơi ngọt, sệt như kem và có vị chát nhẹ đặc trưng của trà xanh, dịu nhẹ và ngát hương.",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/matcha-da-xay(2).jpg",
                        Price = 35,
                        Category = "Nước",
                        Discount = 28
                    },
                    new Product
                    {
                        Name = "Trà đào chanh sả",
                        Description = "Trà đào chanh sả, như chính tên gọi của mình vậy, có vị đậm ngọt thanh của đào, có vị chua chua dịu nhẹ của chanh, có mùi thơm của sả.",
                        Img = "https://github.com/dudq2001/SEM3/blob/master/DrinkStores/tra-dao-chanh-sa(2).jpg",
                        Price = 33.08m,
                        Category = "Trà",
                        Discount = 35
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
