# **Mục lục**

* [Backend](#backend)
* [Frontend](#frontend)
* [Callcenter](#callcenter)
* [Lưu ý](#luu-y)

---

# Backend

## Cài đặt Node.js

Truy cập trang web Node.js: https://nodejs.org/en/ và tải xuống gói cài đặt phù hợp với hệ điều hành của bạn. Sau khi tải xuống, hãy chạy gói cài đặt để cài đặt Node.js.

## Truy cập thư mục server/src

Mở cửa sổ lệnh và điều hướng đến thư mục `server/src`.

## Chạy lệnh `npm i`

Lệnh này sẽ cài đặt các gói phụ thuộc cần thiết cho ứng dụng.

## Chạy lệnh `npm i nodemon --global`

Lệnh này sẽ cài đặt công cụ `nodemon`, giúp tự động khởi động lại ứng dụng khi có thay đổi.

## Cài đặt MySQL trên server

Tải xuống gói cài đặt MySQL phù hợp với hệ điều hành của bạn. Sau khi tải xuống, hãy chạy gói cài đặt để cài đặt MySQL.

## Restore database với file "aloxe.sql"

Tạo một database mới có tên là "aloxe". Sau đó, sử dụng công cụ MySQL để restore database từ file `aloxe.sql`.

## Cấu hình username, password để connect vào database trong file .env hoặc src/config/init.js

Mở file `.env` hoặc `src/config/init.js` và cấu hình các biến sau:

* `DB_HOST`: Địa chỉ IP hoặc tên miền của máy chủ MySQL.
* `DB_PORT`: Cổng kết nối MySQL.
* `DB_USERNAME`: Tên người dùng MySQL.
* `DB_PASSWORD`: Mật khẩu MySQL.

## Chạy lệnh `npm run dev`

Lệnh này sẽ khởi động ứng dụng ở chế độ phát triển.

---

# Frontend

## Cài đặt Node.js

Tương tự như bước 1 trong hướng dẫn cài đặt backend.

## Truy cập thư mục app_mobile_client/hcdh-tpkm

Mở cửa sổ lệnh và điều hướng đến thư mục `app_mobile_client/hcdh-tpkm`.

## Mở cửa sổ lệnh ở thư mục này

Tương tự như bước 3 trong hướng dẫn cài đặt backend.

## Cấu hình app_mobile_client/hcdh-tpkm/src/environment.ts

Mở file `app_mobile_client/hcdh-tpkm/src/environment.ts` và cấu hình các biến sau:

* `BASE_URL`: Địa chỉ URL của ứng dụng backend.

## Chạy lệnh `npm i`

Lệnh này sẽ cài đặt các gói phụ thuộc cần thiết cho ứng dụng.

## Chạy lệnh `npm run dev`

Lệnh này sẽ khởi động ứng dụng ở chế độ phát triển.

---

# Callcenter

## Cài đặt .NET runtime 8.0

Truy cập trang web .NET: https://dotnet.microsoft.com/en-us/download/dotnet/8.0 và tải xuống gói cài đặt phù hợp với hệ điều hành của bạn. Sau khi tải xuống, hãy chạy gói cài đặt để cài đặt .NET runtime 8.0.

## Vào file Aloxe.sln

Mở file `Alaxe.sln` trong Visual Studio.

## Build và run

Nhấp chuột phải vào dự án và chọn "Build". Sau khi build thành công, hãy nhấp chuột phải vào dự án và chọn "Run".

---

# Lưu ý

* Các bước hướng dẫn trên áp dụng cho hệ điều hành Linux. Đối với hệ điều hành Windows và macOS, bạn có thể thực hiện tương tự.
* Để cài đặt ứng dụng trên điện thoại di động, bạn cần tạo một ứng dụng Android hoặc iOS và cài đặt gói `app_mobile_client` vào ứng dụng.

---

# Thay đổi

* Sử dụng định dạng markdown để tạo văn bản rõ ràng và dễ đọc.
* Sử dụng các tiêu đề và đánh dấu để phân chia nội dung.
* Sử dụng các liên kết để điều hướng đến các tài nguyên liên quan.

---

# Bổ sung

* Thêm phần "Lưu ý" để cung cấp thêm thông tin cho người dùng.
* Thêm phần "Thay đổi" để giải thích các thay đổi đã thực hiện đối với hướng dẫn.


**Ngoài ra, bạn có thể tùy chỉnh thêm các phần khác như:**

* Giới thiệu
* Cấu hình hệ thống
* Xử lý lỗi
* FAQs


**Hy vọng hướng dẫn này sẽ giúp bạn cài đặt thành công
