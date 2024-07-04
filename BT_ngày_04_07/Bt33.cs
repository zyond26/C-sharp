/*Nếu bạn bỏ đi get và set ở khai báo Name như sau:

public string Name;

thay vì 
public virtual string Name { get; set; }

thì sẽ có những thay đổi sau:

Không có property setter/getter tự động: Khi không có get và set, 
bạn không thể truy cập hoặc thay đổi giá trị của Name từ bên ngoài lớp Person hay Student. 
Điều này có nghĩa là Name sẽ không có phương thức get và set tự động được sinh ra.

Không thể override hoặc implement lại theo nghĩa đồng bộ: Trong Student class, 
bạn không thể sử dụng override để cung cấp logic kiểm tra như trong trường hợp bạn đang làm. 
Bởi vì override yêu cầu phải có một property virtual với cả get và set.

Không thể sử dụng các tính năng của property: Bạn sẽ không thể sử dụng các tính năng như validation 
(kiểm tra hợp lệ) trong setter như bạn đã thực hiện với base.Name = value;.

*/