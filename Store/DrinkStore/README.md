# B1: Chạy dotnet ef database drop --force --context StoreDbContext
Xóa database
# B2: Hiển thị dữ liệu ra màn hình 
Sửa controller
Lưu ý phải có View(repository.Products); thì mới đẩy được dữ liệu ra
# B3: Phân trang
Sửa controller
Thêm PagingInfo
Tạo forder Infrastructure => tạo class PageLinkTagHelper
# B4: Sửa file _ViewImpost.cshtml
@using AhihiStore.Models.ViewModels;
@addTagHelper*, AhihiStore;
# B5: Tạo forder ViewModel trong Models
Tạo class PagingInfo
# B6: Tạo viewmodels data
- Tạo class PagingInfo
- Tạo class ProductsListViewModel
# B7: Tạo productListViewModel trong ViewModels