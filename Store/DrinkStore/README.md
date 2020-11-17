b1: dotnet ef database drop --force --context StoreDbContext
xóa database
b2:Hiển thị dữ liệu ra màn hình 
sửa controller
lưu ý phải có View(repository.Products); thì mới đẩy được dữ liệu ra
b3:phân trang
Sửa controller
Thêm PagingInfo
tạo forder Infrastructure => tạo class PageLinkTagHelper
b4: sửa file _ViewImpost.cshtml
@using AhihiStore.Models.ViewModels;
@addTagHelper*, AhihiStore;
b5: tạo forder ViewModel trong Models
+ tạo class PagingInfo
b6: tạo viewmodels data
+ tạo class PagingInfo
+ tạo class ProductsListViewModel
b7: tạo productListViewModel trong ViewModels