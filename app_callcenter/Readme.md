# Hướng dẫn cài đặt và chạy ứng dụng .NET Core

## Bước 1: Cài đặt .NET runtime 8.0

1. Truy cập trang web [https://dotnet.microsoft.com/en-us/download/dotnet/8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
2. Chọn phiên bản .NET runtime phù hợp với hệ điều hành của bạn
3. Tải xuống và chạy tệp cài đặt

## Bước 2: Thêm và cập nhật cơ sở dữ liệu

1. Mở cửa sổ lệnh
2. Điều hướng đến thư mục chứa ứng dụng của bạn
3. Nhập lệnh `dotnet ef add-migration`
4. Nhập lệnh `dotnet ef update-database`

## Bước 3: Build và run ứng dụng

1. Mở cửa sổ lệnh
2. Điều hướng đến thư mục chứa ứng dụng của bạn
3. Nhập lệnh `dotnet build`
4. Nhập lệnh `dotnet run`
