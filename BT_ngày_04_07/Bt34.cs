/*
So sánh abstract và virtual
Đặc điểm	                  abstract	                                             virtual
Cần lớp abstract:	            Có                              	  Không cần
Thân hàm:	            Không có thân hàm (chỉ khai báo)	          Có thể có thân hàm mặc định
Bắt buộc ghi đè:	        Lớp dẫn xuất phải ghi đè	              Lớp dẫn xuất có thể ghi đè nhưng không bắt buộc
Sử dụng khi nào:	  Khi cần đảm bảo lớp dẫn xuất cung cấp 
                        một  cài đặt cụ thể	                           Khi muốn cung cấp một cài đặt mặc định nhưng cho 
                                                                      phép ghi đè


Khi nào sử dụng abstract hoặc virtual?
Sử dụng abstract: Khi bạn muốn đảm bảo rằng mỗi lớp dẫn xuất phải cung cấp một triển khai cụ thể cho mộ
t phương thức hoặc thuộc tính. Điều này thường xảy ra trong các tình huống khi lớp cơ sở không thể cung cấp 
một triển khai hợp lý hoặc khi mỗi loại dẫn xuất cần có một hành vi khác nhau rõ ràng.

Sử dụng virtual: Khi bạn muốn cung cấp một triển khai mặc định nhưng vẫn muốn cho phép các lớp dẫn xuất có thể 
thay đổi hành vi đó nếu cần. Điều này hữu ích khi lớp cơ sở có thể cung cấp một triển khai hợp lý cho đa số các lớp dẫn xuất, 
nhưng vẫn cho phép tùy biến.


*/