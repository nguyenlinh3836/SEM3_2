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
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_32974763_1198037793670751_2405859736541986816_n_thumbcr_364x271.png",
                        Price = 50,
                        Category = "Trà",
                        Discount = 35
                    },
                    new Product
                    {
                        Name = "Cafe-latte",
                        Description = "Cafe latte được tạo hình một cách nghệ thuật, độc đáo",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33058655_1198037763670754_2207856225163411456_n_thumbcr_364x271.png",
                        Price = 60,
                        Category = "Cà phê",
                        Discount = 45
                    },
                    new Product
                    {
                        Name = "Ca-cao",
                        Description = "Cacao không chỉ ngon mà còn rất bổ dưỡng, cacao giàu protein, chứa nhiều axit béo",
                        Img= "http://royaltea.vn/temp/uploaded-san%20pham_33083909_1198037773670753_3116257398998695936_n_thumbcr_364x271.png",
                        Price = 35,
                        Category = "Nước",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Trà sữa chân trâu đường đen",                      
                        Description = "Món đồ uống này không hề có các nguyên liệu cầu kỳ mà chỉ là vị sữa thơm ngậy, trân châu giòn ngon ngấm vị đường",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33058655_1198037763670754_2207856225163411456_n_thumbcr_364x271.png",
                        Price = 40,
                        Category = "Trà",
                        Discount = 30
                    },
                    new Product
                    {
                        Name = "Sinh tố",
                        Description = "Sinh tố là món nước uống được pha chế từ các loại trái cây tươi, đá và nước ép trái cây hoặc sirô để lạnh",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33081272_1198037760337421_3481262952676327424_n_thumbcr_364x271.png",
                        Price = 30,
                        Category = "Nước",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Socola đá việt quất",
                        Description = "Soda việt quất với màu sắc bắt mắt cùng hương vị tuyệt vời",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33081272_1198037760337421_3481262952676327424_n_thumbcr_364x271.png",
                        Price = 42,
                        Category = "Nước",
                        Discount = 35
                    },
                    new Product
                    {
                        Name = "Trà hoa quả",
                        Description = "Vị chua, vị ngọt của hoa quả hòa quyện với vị chan chát của trà sẽ mang đến những cảm giác sảng khoái cho ngày hè oi bức.",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33136425_1198037753670755_6011816456088453120_n_thumbcr_364x271.png",
                        Price = 25,
                        Category = "Trà",
                        Discount = 20
                    },
                    new Product
                    {
                        Name = "Matcha đá xay",
                        Description = "Matcha đá xay có vị hơi ngọt, sệt như kem và có vị chát nhẹ đặc trưng của trà xanh, dịu nhẹ và ngát hương.",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33038128_1198037780337419_1819453467773632512_n_thumbcr_364x271.png",
                        Price = 35,
                        Category = "Nước",
                        Discount = 28
                    },
                    new Product
                    {
                        Name = "Trà đào chanh sả",
                        Description = "Trà đào chanh sả, như chính tên gọi của mình vậy, có vị đậm ngọt thanh của đào, có vị chua chua dịu nhẹ của chanh, có mùi thơm của sả.",
                        Img = "http://royaltea.vn/temp/uploaded-san%20pham_33058655_1198037763670754_2207856225163411456_n_thumbcr_364x271.png",
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
