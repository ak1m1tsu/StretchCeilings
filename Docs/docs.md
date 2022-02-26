<a name='assembly'></a>
# StretchCeilings documentation
<hr>

## Contents

- [AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-AdditionalService-DeletedDate 'StretchCeilings.Domain.Models.AdditionalService.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-AdditionalService-Id 'StretchCeilings.Domain.Models.AdditionalService.Id')
  - [Name](#P-StretchCeilings-Domain-Models-AdditionalService-Name 'StretchCeilings.Domain.Models.AdditionalService.Name')
  - [Price](#P-StretchCeilings-Domain-Models-AdditionalService-Price 'StretchCeilings.Domain.Models.AdditionalService.Price')
  - [Add()](#M-StretchCeilings-Domain-Models-AdditionalService-Add 'StretchCeilings.Domain.Models.AdditionalService.Add')
  - [CountInOrders(dateFrom,dateUntil)](#M-StretchCeilings-Domain-Models-AdditionalService-CountInOrders-System-DateTime,System-DateTime- 'StretchCeilings.Domain.Models.AdditionalService.CountInOrders(System.DateTime,System.DateTime)')
  - [Delete()](#M-StretchCeilings-Domain-Models-AdditionalService-Delete 'StretchCeilings.Domain.Models.AdditionalService.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-AdditionalService-Update 'StretchCeilings.Domain.Models.AdditionalService.Update')
- [AdditionalServiceProperty](#T-StretchCeilings-Domain-Enums-AdditionalServiceProperty 'StretchCeilings.Domain.Enums.AdditionalServiceProperty')
- [Ceiling](#T-StretchCeilings-Domain-Models-Ceiling 'StretchCeilings.Domain.Models.Ceiling')
  - [ColorType](#P-StretchCeilings-Domain-Models-Ceiling-ColorType 'StretchCeilings.Domain.Models.Ceiling.ColorType')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Ceiling-DeletedDate 'StretchCeilings.Domain.Models.Ceiling.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Ceiling-Id 'StretchCeilings.Domain.Models.Ceiling.Id')
  - [Manufacturer](#P-StretchCeilings-Domain-Models-Ceiling-Manufacturer 'StretchCeilings.Domain.Models.Ceiling.Manufacturer')
  - [ManufacturerId](#P-StretchCeilings-Domain-Models-Ceiling-ManufacturerId 'StretchCeilings.Domain.Models.Ceiling.ManufacturerId')
  - [Name](#P-StretchCeilings-Domain-Models-Ceiling-Name 'StretchCeilings.Domain.Models.Ceiling.Name')
  - [Price](#P-StretchCeilings-Domain-Models-Ceiling-Price 'StretchCeilings.Domain.Models.Ceiling.Price')
  - [TextureType](#P-StretchCeilings-Domain-Models-Ceiling-TextureType 'StretchCeilings.Domain.Models.Ceiling.TextureType')
  - [Add()](#M-StretchCeilings-Domain-Models-Ceiling-Add 'StretchCeilings.Domain.Models.Ceiling.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Ceiling-Delete 'StretchCeilings.Domain.Models.Ceiling.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-Ceiling-Update 'StretchCeilings.Domain.Models.Ceiling.Update')
- [ColorType](#T-StretchCeilings-Domain-Models-Enums-ColorType 'StretchCeilings.Domain.Models.Enums.ColorType')
- [Country](#T-StretchCeilings-Domain-Models-Enums-Country 'StretchCeilings.Domain.Models.Enums.Country')
- [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Customer-DeletedDate 'StretchCeilings.Domain.Models.Customer.DeletedDate')
  - [FullName](#P-StretchCeilings-Domain-Models-Customer-FullName 'StretchCeilings.Domain.Models.Customer.FullName')
  - [Id](#P-StretchCeilings-Domain-Models-Customer-Id 'StretchCeilings.Domain.Models.Customer.Id')
  - [PhoneNumber](#P-StretchCeilings-Domain-Models-Customer-PhoneNumber 'StretchCeilings.Domain.Models.Customer.PhoneNumber')
  - [Add()](#M-StretchCeilings-Domain-Models-Customer-Add 'StretchCeilings.Domain.Models.Customer.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Customer-Delete 'StretchCeilings.Domain.Models.Customer.Delete')
  - [GetEstates()](#M-StretchCeilings-Domain-Models-Customer-GetEstates 'StretchCeilings.Domain.Models.Customer.GetEstates')
  - [GetOrders()](#M-StretchCeilings-Domain-Models-Customer-GetOrders 'StretchCeilings.Domain.Models.Customer.GetOrders')
  - [GetOrdersCount()](#M-StretchCeilings-Domain-Models-Customer-GetOrdersCount-System-DateTime,System-DateTime- 'StretchCeilings.Domain.Models.Customer.GetOrdersCount(System.DateTime,System.DateTime)')
  - [Update()](#M-StretchCeilings-Domain-Models-Customer-Update 'StretchCeilings.Domain.Models.Customer.Update')
- [CustomerProperty](#T-StretchCeilings-Domain-Enums-CustomerProperty 'StretchCeilings.Domain.Enums.CustomerProperty')
- [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Employee-DeletedDate 'StretchCeilings.Domain.Models.Employee.DeletedDate')
  - [FullName](#P-StretchCeilings-Domain-Models-Employee-FullName 'StretchCeilings.Domain.Models.Employee.FullName')
  - [Id](#P-StretchCeilings-Domain-Models-Employee-Id 'StretchCeilings.Domain.Models.Employee.Id')
  - [Login](#P-StretchCeilings-Domain-Models-Employee-Login 'StretchCeilings.Domain.Models.Employee.Login')
  - [Password](#P-StretchCeilings-Domain-Models-Employee-Password 'StretchCeilings.Domain.Models.Employee.Password')
  - [Role](#P-StretchCeilings-Domain-Models-Employee-Role 'StretchCeilings.Domain.Models.Employee.Role')
  - [RoleId](#P-StretchCeilings-Domain-Models-Employee-RoleId 'StretchCeilings.Domain.Models.Employee.RoleId')
  - [Add()](#M-StretchCeilings-Domain-Models-Employee-Add 'StretchCeilings.Domain.Models.Employee.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Employee-Delete 'StretchCeilings.Domain.Models.Employee.Delete')
  - [GetSchedule()](#M-StretchCeilings-Domain-Models-Employee-GetSchedule 'StretchCeilings.Domain.Models.Employee.GetSchedule')
  - [Update()](#M-StretchCeilings-Domain-Models-Employee-Update 'StretchCeilings.Domain.Models.Employee.Update')
- [EmployeeProperty](#T-StretchCeilings-Domain-Enums-EmployeeProperty 'StretchCeilings.Domain.Enums.EmployeeProperty')
- [EnumExtensions](#T-StretchCeilings-Domain-Extensions-EnumExtensions 'StretchCeilings.Domain.Extensions.EnumExtensions')
  - [ParseString(colorType)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-ColorType- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.ColorType)')
  - [ParseString(code)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-PermissionCode- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.PermissionCode)')
  - [ParseString(status)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-OrderStatus- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.OrderStatus)')
  - [ParseString(textureType)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-TextureType- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.TextureType)')
  - [ParseString(type)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-RoomType- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.RoomType)')
  - [ParseString(type)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-Country- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Models.Enums.Country)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-OrderProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.OrderProperty)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-AdditionalServiceProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.AdditionalServiceProperty)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-CustomerProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.CustomerProperty)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-EmployeeProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.EmployeeProperty)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-ManufacturerProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.ManufacturerProperty)')
  - [ParseString(property)](#M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-ServiceProperty- 'StretchCeilings.Domain.Extensions.EnumExtensions.ParseString(StretchCeilings.Domain.Enums.ServiceProperty)')
- [Estate](#T-StretchCeilings-Domain-Models-Estate 'StretchCeilings.Domain.Models.Estate')
  - [Address](#P-StretchCeilings-Domain-Models-Estate-Address 'StretchCeilings.Domain.Models.Estate.Address')
  - [Customer](#P-StretchCeilings-Domain-Models-Estate-Customer 'StretchCeilings.Domain.Models.Estate.Customer')
  - [CustomerId](#P-StretchCeilings-Domain-Models-Estate-CustomerId 'StretchCeilings.Domain.Models.Estate.CustomerId')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Estate-DeletedDate 'StretchCeilings.Domain.Models.Estate.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Estate-Id 'StretchCeilings.Domain.Models.Estate.Id')
  - [Add()](#M-StretchCeilings-Domain-Models-Estate-Add 'StretchCeilings.Domain.Models.Estate.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Estate-Delete 'StretchCeilings.Domain.Models.Estate.Delete')
  - [GetRooms()](#M-StretchCeilings-Domain-Models-Estate-GetRooms 'StretchCeilings.Domain.Models.Estate.GetRooms')
  - [Update()](#M-StretchCeilings-Domain-Models-Estate-Update 'StretchCeilings.Domain.Models.Estate.Update')
- [IAdditionalServiceRepository](#T-StretchCeilings-Domain-Repositories-IAdditionalServiceRepository 'StretchCeilings.Domain.Repositories.IAdditionalServiceRepository')
  - [GetAll(firstFilter,secondsFilter,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IAdditionalServiceRepository-GetAll-StretchCeilings-Domain-Models-AdditionalService,StretchCeilings-Domain-Models-AdditionalService,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-AdditionalServiceProperty- 'StretchCeilings.Domain.Repositories.IAdditionalServiceRepository.GetAll(StretchCeilings.Domain.Models.AdditionalService,StretchCeilings.Domain.Models.AdditionalService,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.AdditionalServiceProperty)')
- [IAuthService](#T-StretchCeilings-Domain-Services-IAuthService 'StretchCeilings.Domain.Services.IAuthService')
  - [Login(login,password)](#M-StretchCeilings-Domain-Services-IAuthService-Login-System-String,System-String- 'StretchCeilings.Domain.Services.IAuthService.Login(System.String,System.String)')
- [ICustomer](#T-StretchCeilings-Domain-Models-Interfaces-ICustomer 'StretchCeilings.Domain.Models.Interfaces.ICustomer')
  - [GetEstates()](#M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetEstates 'StretchCeilings.Domain.Models.Interfaces.ICustomer.GetEstates')
  - [GetOrders()](#M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetOrders 'StretchCeilings.Domain.Models.Interfaces.ICustomer.GetOrders')
  - [GetOrdersCount(dateFrom,dateUntil)](#M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetOrdersCount-System-DateTime,System-DateTime- 'StretchCeilings.Domain.Models.Interfaces.ICustomer.GetOrdersCount(System.DateTime,System.DateTime)')
- [ICustomerRepository](#T-StretchCeilings-Domain-Repositories-ICustomerRepository 'StretchCeilings.Domain.Repositories.ICustomerRepository')
  - [GetAll(filter,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-ICustomerRepository-GetAll-StretchCeilings-Domain-Models-Customer,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-CustomerProperty- 'StretchCeilings.Domain.Repositories.ICustomerRepository.GetAll(StretchCeilings.Domain.Models.Customer,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.CustomerProperty)')
- [IDbModel](#T-StretchCeilings-Domain-Models-Interfaces-IDbModel 'StretchCeilings.Domain.Models.Interfaces.IDbModel')
  - [Add()](#M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Add 'StretchCeilings.Domain.Models.Interfaces.IDbModel.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Delete 'StretchCeilings.Domain.Models.Interfaces.IDbModel.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Update 'StretchCeilings.Domain.Models.Interfaces.IDbModel.Update')
- [IEmployee](#T-StretchCeilings-Domain-Models-Interfaces-IEmployee 'StretchCeilings.Domain.Models.Interfaces.IEmployee')
  - [GetSchedule()](#M-StretchCeilings-Domain-Models-Interfaces-IEmployee-GetSchedule 'StretchCeilings.Domain.Models.Interfaces.IEmployee.GetSchedule')
- [IEmployeeRepository](#T-StretchCeilings-Domain-Repositories-IEmployeeRepository 'StretchCeilings.Domain.Repositories.IEmployeeRepository')
  - [FindByLogin(login)](#M-StretchCeilings-Domain-Repositories-IEmployeeRepository-FindByLogin-System-String- 'StretchCeilings.Domain.Repositories.IEmployeeRepository.FindByLogin(System.String)')
  - [GetAll(filter,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IEmployeeRepository-GetAll-StretchCeilings-Domain-Models-Employee,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-EmployeeProperty- 'StretchCeilings.Domain.Repositories.IEmployeeRepository.GetAll(StretchCeilings.Domain.Models.Employee,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.EmployeeProperty)')
- [IEstate](#T-StretchCeilings-Domain-Models-Interfaces-IEstate 'StretchCeilings.Domain.Models.Interfaces.IEstate')
  - [GetRooms()](#M-StretchCeilings-Domain-Models-Interfaces-IEstate-GetRooms 'StretchCeilings.Domain.Models.Interfaces.IEstate.GetRooms')
- [IManufacturer](#T-StretchCeilings-Domain-Models-Interfaces-IManufacturer 'StretchCeilings.Domain.Models.Interfaces.IManufacturer')
  - [GetCeilings()](#M-StretchCeilings-Domain-Models-Interfaces-IManufacturer-GetCeilings 'StretchCeilings.Domain.Models.Interfaces.IManufacturer.GetCeilings')
- [IManufacturerRepository](#T-StretchCeilings-Domain-Repositories-IManufacturerRepository 'StretchCeilings.Domain.Repositories.IManufacturerRepository')
  - [GetAll(filter,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IManufacturerRepository-GetAll-StretchCeilings-Domain-Models-Manufacturer,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-ManufacturerProperty- 'StretchCeilings.Domain.Repositories.IManufacturerRepository.GetAll(StretchCeilings.Domain.Models.Manufacturer,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.ManufacturerProperty)')
- [IOrder](#T-StretchCeilings-Domain-Models-Interfaces-IOrder 'StretchCeilings.Domain.Models.Interfaces.IOrder')
  - [CalculateTotal()](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-CalculateTotal 'StretchCeilings.Domain.Models.Interfaces.IOrder.CalculateTotal')
  - [GetEmployees()](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetEmployees 'StretchCeilings.Domain.Models.Interfaces.IOrder.GetEmployees')
  - [GetLogs()](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetLogs 'StretchCeilings.Domain.Models.Interfaces.IOrder.GetLogs')
  - [GetServices()](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetServices 'StretchCeilings.Domain.Models.Interfaces.IOrder.GetServices')
  - [GetWorkDates()](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetWorkDates 'StretchCeilings.Domain.Models.Interfaces.IOrder.GetWorkDates')
  - [RemoveEmployee(id)](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-RemoveEmployee-System-Int32- 'StretchCeilings.Domain.Models.Interfaces.IOrder.RemoveEmployee(System.Int32)')
  - [RemoveService(id)](#M-StretchCeilings-Domain-Models-Interfaces-IOrder-RemoveService-System-Int32- 'StretchCeilings.Domain.Models.Interfaces.IOrder.RemoveService(System.Int32)')
- [IOrderRepository](#T-StretchCeilings-Domain-Repositories-IOrderRepository 'StretchCeilings.Domain.Repositories.IOrderRepository')
  - [GetAll(firstFilter,secondFilter,customer,employee,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IOrderRepository-GetAll-StretchCeilings-Domain-Models-Order,StretchCeilings-Domain-Models-Order,StretchCeilings-Domain-Models-Customer,StretchCeilings-Domain-Models-Employee,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-OrderProperty- 'StretchCeilings.Domain.Repositories.IOrderRepository.GetAll(StretchCeilings.Domain.Models.Order,StretchCeilings.Domain.Models.Order,StretchCeilings.Domain.Models.Customer,StretchCeilings.Domain.Models.Employee,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.OrderProperty)')
- [IRepository](#T-StretchCeilings-Domain-IRepository 'StretchCeilings.Domain.IRepository')
  - [FindById(id)](#M-StretchCeilings-Domain-IRepository-FindById-System-Int32 'StretchCeilings.Domain.IRepository.FindById(System.Int32)')
  - [GetAll()](#M-StretchCeilings-Domain-IRepository-GetAll 'StretchCeilings.Domain.IRepository`1.GetAll')
- [IRole](#T-StretchCeilings-Domain-Models-Interfaces-IRole 'StretchCeilings.Domain.Models.Interfaces.IRole')
  - [AddPermission(permission)](#M-StretchCeilings-Domain-Models-Interfaces-IRole-AddPermission-StretchCeilings-Domain-Models-Permission- 'StretchCeilings.Domain.Models.Interfaces.IRole.AddPermission(StretchCeilings.Domain.Models.Permission)')
  - [DeletePermission(permission)](#M-StretchCeilings-Domain-Models-Interfaces-IRole-DeletePermission-StretchCeilings-Domain-Models-Permission- 'StretchCeilings.Domain.Models.Interfaces.IRole.DeletePermission(StretchCeilings.Domain.Models.Permission)')
  - [GetPermissions()](#M-StretchCeilings-Domain-Models-Interfaces-IRole-GetPermissions 'StretchCeilings.Domain.Models.Interfaces.IRole.GetPermissions')
- [IRoleRepository](#T-StretchCeilings-Domain-Repositories-IRoleRepository 'StretchCeilings.Domain.Repositories.IRoleRepository')
- [IRoomRepository](#T-StretchCeilings-Domain-Repositories-IRoomRepository 'StretchCeilings.Domain.Repositories.IRoomRepository')
  - [GetAll(customer,estate,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IRoomRepository-GetAll-StretchCeilings-Domain-Models-Customer,StretchCeilings-Domain-Models-Estate,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-RoomProperty- 'StretchCeilings.Domain.Repositories.IRoomRepository.GetAll(StretchCeilings.Domain.Models.Customer,StretchCeilings.Domain.Models.Estate,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.RoomProperty)')
- [IService](#T-StretchCeilings-Domain-Models-Interfaces-IService 'StretchCeilings.Domain.Models.Interfaces.IService')
  - [CalculatePrice()](#M-StretchCeilings-Domain-Models-Interfaces-IService-CalculatePrice 'StretchCeilings.Domain.Models.Interfaces.IService.CalculatePrice')
  - [GetAdditionalServices()](#M-StretchCeilings-Domain-Models-Interfaces-IService-GetAdditionalServices 'StretchCeilings.Domain.Models.Interfaces.IService.GetAdditionalServices')
- [IServiceRepository](#T-StretchCeilings-Domain-Repositories-IServiceRepository 'StretchCeilings.Domain.Repositories.IServiceRepository')
  - [GetAll(firstFilter,secondFilter,count,page,option,property)](#M-StretchCeilings-Domain-Repositories-IServiceRepository-GetAll-StretchCeilings-Domain-Models-Service,StretchCeilings-Domain-Models-Service,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-ServiceProperty- 'StretchCeilings.Domain.Repositories.IServiceRepository.GetAll(StretchCeilings.Domain.Models.Service,StretchCeilings.Domain.Models.Service,System.Int32,System.Int32,StretchCeilings.Domain.Enums.SortOption,StretchCeilings.Domain.Enums.ServiceProperty)')
- [Log](#T-StretchCeilings-Domain-Models-Log 'StretchCeilings.Domain.Models.Log')
  - [Comment](#P-StretchCeilings-Domain-Models-Log-Comment 'StretchCeilings.Domain.Models.Log.Comment')
  - [DateCreated](#P-StretchCeilings-Domain-Models-Log-DateCreated 'StretchCeilings.Domain.Models.Log.DateCreated')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Log-DeletedDate 'StretchCeilings.Domain.Models.Log.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Log-Id 'StretchCeilings.Domain.Models.Log.Id')
  - [Order](#P-StretchCeilings-Domain-Models-Log-Order 'StretchCeilings.Domain.Models.Log.Order')
  - [OrderId](#P-StretchCeilings-Domain-Models-Log-OrderId 'StretchCeilings.Domain.Models.Log.OrderId')
  - [Add()](#M-StretchCeilings-Domain-Models-Log-Add 'StretchCeilings.Domain.Models.Log.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Log-Delete 'StretchCeilings.Domain.Models.Log.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-Log-Update 'StretchCeilings.Domain.Models.Log.Update')
- [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer')
  - [Address](#P-StretchCeilings-Domain-Models-Manufacturer-Address 'StretchCeilings.Domain.Models.Manufacturer.Address')
  - [Country](#P-StretchCeilings-Domain-Models-Manufacturer-Country 'StretchCeilings.Domain.Models.Manufacturer.Country')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Manufacturer-DeletedDate 'StretchCeilings.Domain.Models.Manufacturer.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Manufacturer-Id 'StretchCeilings.Domain.Models.Manufacturer.Id')
  - [Name](#P-StretchCeilings-Domain-Models-Manufacturer-Name 'StretchCeilings.Domain.Models.Manufacturer.Name')
  - [Add()](#M-StretchCeilings-Domain-Models-Manufacturer-Add 'StretchCeilings.Domain.Models.Manufacturer.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Manufacturer-Delete 'StretchCeilings.Domain.Models.Manufacturer.Delete')
  - [GetCeilings()](#M-StretchCeilings-Domain-Models-Manufacturer-GetCeilings 'StretchCeilings.Domain.Models.Manufacturer.GetCeilings')
  - [Update()](#M-StretchCeilings-Domain-Models-Manufacturer-Update 'StretchCeilings.Domain.Models.Manufacturer.Update')
- [ManufacturerProperty](#T-StretchCeilings-Domain-Enums-ManufacturerProperty 'StretchCeilings.Domain.Enums.ManufacturerProperty')
- [ModelHelper](#T-StretchCeilings-Domain-Helpers-ModelHelper 'StretchCeilings.Domain.Helpers.ModelHelper')
  - [HasNullField(manufacturer)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Manufacturer- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Manufacturer)')
  - [HasNullField(estate)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Estate- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Estate)')
  - [HasNullField(order)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Order- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Order)')
  - [HasNullField(customer)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Customer- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Customer)')
  - [HasNullField(employee)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Employee- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Employee)')
  - [HasNullField(service)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Service- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Service)')
  - [HasNullField(room)](#M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Room- 'StretchCeilings.Domain.Helpers.ModelHelper.HasNullField(StretchCeilings.Domain.Models.Room)')
- [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order')
  - [Customer](#P-StretchCeilings-Domain-Models-Order-Customer 'StretchCeilings.Domain.Models.Order.Customer')
  - [CustomerId](#P-StretchCeilings-Domain-Models-Order-CustomerId 'StretchCeilings.Domain.Models.Order.CustomerId')
  - [DateCanceled](#P-StretchCeilings-Domain-Models-Order-DateCanceled 'StretchCeilings.Domain.Models.Order.DateCanceled')
  - [DateOfMeasurements](#P-StretchCeilings-Domain-Models-Order-DateOfMeasurements 'StretchCeilings.Domain.Models.Order.DateOfMeasurements')
  - [DatePaid](#P-StretchCeilings-Domain-Models-Order-DatePaid 'StretchCeilings.Domain.Models.Order.DatePaid')
  - [DatePlaced](#P-StretchCeilings-Domain-Models-Order-DatePlaced 'StretchCeilings.Domain.Models.Order.DatePlaced')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Order-DeletedDate 'StretchCeilings.Domain.Models.Order.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Order-Id 'StretchCeilings.Domain.Models.Order.Id')
  - [PaidByCash](#P-StretchCeilings-Domain-Models-Order-PaidByCash 'StretchCeilings.Domain.Models.Order.PaidByCash')
  - [Status](#P-StretchCeilings-Domain-Models-Order-Status 'StretchCeilings.Domain.Models.Order.Status')
  - [Total](#P-StretchCeilings-Domain-Models-Order-Total 'StretchCeilings.Domain.Models.Order.Total')
  - [Add()](#M-StretchCeilings-Domain-Models-Order-Add 'StretchCeilings.Domain.Models.Order.Add')
  - [CalculateTotal()](#M-StretchCeilings-Domain-Models-Order-CalculateTotal 'StretchCeilings.Domain.Models.Order.CalculateTotal')
  - [Delete()](#M-StretchCeilings-Domain-Models-Order-Delete 'StretchCeilings.Domain.Models.Order.Delete')
  - [GetEmployees()](#M-StretchCeilings-Domain-Models-Order-GetEmployees 'StretchCeilings.Domain.Models.Order.GetEmployees')
  - [GetLogs()](#M-StretchCeilings-Domain-Models-Order-GetLogs 'StretchCeilings.Domain.Models.Order.GetLogs')
  - [GetServices()](#M-StretchCeilings-Domain-Models-Order-GetServices 'StretchCeilings.Domain.Models.Order.GetServices')
  - [GetWorkDates()](#M-StretchCeilings-Domain-Models-Order-GetWorkDates 'StretchCeilings.Domain.Models.Order.GetWorkDates')
  - [RemoveEmployee()](#M-StretchCeilings-Domain-Models-Order-RemoveEmployee-System-Int32- 'StretchCeilings.Domain.Models.Order.RemoveEmployee(System.Int32)')
  - [RemoveService()](#M-StretchCeilings-Domain-Models-Order-RemoveService-System-Int32- 'StretchCeilings.Domain.Models.Order.RemoveService(System.Int32)')
  - [Update()](#M-StretchCeilings-Domain-Models-Order-Update 'StretchCeilings.Domain.Models.Order.Update')
- [OrderEmployee](#T-StretchCeilings-Domain-Models-OrderEmployee 'StretchCeilings.Domain.Models.OrderEmployee')
  - [Employee](#P-StretchCeilings-Domain-Models-OrderEmployee-Employee 'StretchCeilings.Domain.Models.OrderEmployee.Employee')
  - [EmployeeId](#P-StretchCeilings-Domain-Models-OrderEmployee-EmployeeId 'StretchCeilings.Domain.Models.OrderEmployee.EmployeeId')
  - [Order](#P-StretchCeilings-Domain-Models-OrderEmployee-Order 'StretchCeilings.Domain.Models.OrderEmployee.Order')
  - [OrderId](#P-StretchCeilings-Domain-Models-OrderEmployee-OrderId 'StretchCeilings.Domain.Models.OrderEmployee.OrderId')
  - [Add()](#M-StretchCeilings-Domain-Models-OrderEmployee-Add 'StretchCeilings.Domain.Models.OrderEmployee.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-OrderEmployee-Delete 'StretchCeilings.Domain.Models.OrderEmployee.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-OrderEmployee-Update 'StretchCeilings.Domain.Models.OrderEmployee.Update')
- [OrderProperty](#T-StretchCeilings-Domain-Enums-OrderProperty 'StretchCeilings.Domain.Enums.OrderProperty')
- [OrderService](#T-StretchCeilings-Domain-Models-OrderService 'StretchCeilings.Domain.Models.OrderService')
  - [Order](#P-StretchCeilings-Domain-Models-OrderService-Order 'StretchCeilings.Domain.Models.OrderService.Order')
  - [OrderId](#P-StretchCeilings-Domain-Models-OrderService-OrderId 'StretchCeilings.Domain.Models.OrderService.OrderId')
  - [Service](#P-StretchCeilings-Domain-Models-OrderService-Service 'StretchCeilings.Domain.Models.OrderService.Service')
  - [ServiceId](#P-StretchCeilings-Domain-Models-OrderService-ServiceId 'StretchCeilings.Domain.Models.OrderService.ServiceId')
  - [Add()](#M-StretchCeilings-Domain-Models-OrderService-Add 'StretchCeilings.Domain.Models.OrderService.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-OrderService-Delete 'StretchCeilings.Domain.Models.OrderService.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-OrderService-Update 'StretchCeilings.Domain.Models.OrderService.Update')
- [OrderStatus](#T-StretchCeilings-Domain-Models-Enums-OrderStatus 'StretchCeilings.Domain.Models.Enums.OrderStatus')
- [OrderWorkDate](#T-StretchCeilings-Domain-Models-OrderWorkDate 'StretchCeilings.Domain.Models.OrderWorkDate')
  - [DateOfWork](#P-StretchCeilings-Domain-Models-OrderWorkDate-DateOfWork 'StretchCeilings.Domain.Models.OrderWorkDate.DateOfWork')
  - [Order](#P-StretchCeilings-Domain-Models-OrderWorkDate-Order 'StretchCeilings.Domain.Models.OrderWorkDate.Order')
  - [OrderId](#P-StretchCeilings-Domain-Models-OrderWorkDate-OrderId 'StretchCeilings.Domain.Models.OrderWorkDate.OrderId')
  - [Add()](#M-StretchCeilings-Domain-Models-OrderWorkDate-Add 'StretchCeilings.Domain.Models.OrderWorkDate.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-OrderWorkDate-Delete 'StretchCeilings.Domain.Models.OrderWorkDate.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-OrderWorkDate-Update 'StretchCeilings.Domain.Models.OrderWorkDate.Update')
- [Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission')
  - [Code](#P-StretchCeilings-Domain-Models-Permission-Code 'StretchCeilings.Domain.Models.Permission.Code')
  - [Id](#P-StretchCeilings-Domain-Models-Permission-Id 'StretchCeilings.Domain.Models.Permission.Id')
  - [Name](#P-StretchCeilings-Domain-Models-Permission-Name 'StretchCeilings.Domain.Models.Permission.Name')
  - [Add()](#M-StretchCeilings-Domain-Models-Permission-Add 'StretchCeilings.Domain.Models.Permission.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Permission-Delete 'StretchCeilings.Domain.Models.Permission.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-Permission-Update 'StretchCeilings.Domain.Models.Permission.Update')
- [PermissionCode](#T-StretchCeilings-Domain-Models-Enums-PermissionCode 'StretchCeilings.Domain.Models.Enums.PermissionCode')
- [Role](#T-StretchCeilings-Domain-Models-Role 'StretchCeilings.Domain.Models.Role')
  - [Id](#P-StretchCeilings-Domain-Models-Role-Id 'StretchCeilings.Domain.Models.Role.Id')
  - [Name](#P-StretchCeilings-Domain-Models-Role-Name 'StretchCeilings.Domain.Models.Role.Name')
  - [Add()](#M-StretchCeilings-Domain-Models-Role-Add 'StretchCeilings.Domain.Models.Role.Add')
  - [AddPermission()](#M-StretchCeilings-Domain-Models-Role-AddPermission-StretchCeilings-Domain-Models-Permission- 'StretchCeilings.Domain.Models.Role.AddPermission(StretchCeilings.Domain.Models.Permission)')
  - [Delete()](#M-StretchCeilings-Domain-Models-Role-Delete 'StretchCeilings.Domain.Models.Role.Delete')
  - [DeletePermission()](#M-StretchCeilings-Domain-Models-Role-DeletePermission-StretchCeilings-Domain-Models-Permission- 'StretchCeilings.Domain.Models.Role.DeletePermission(StretchCeilings.Domain.Models.Permission)')
  - [GetPermissions()](#M-StretchCeilings-Domain-Models-Role-GetPermissions 'StretchCeilings.Domain.Models.Role.GetPermissions')
  - [Update()](#M-StretchCeilings-Domain-Models-Role-Update 'StretchCeilings.Domain.Models.Role.Update')
- [RolePermission](#T-StretchCeilings-Domain-Models-RolePermission 'StretchCeilings.Domain.Models.RolePermission')
  - [Permission](#P-StretchCeilings-Domain-Models-RolePermission-Permission 'StretchCeilings.Domain.Models.RolePermission.Permission')
  - [PermissionId](#P-StretchCeilings-Domain-Models-RolePermission-PermissionId 'StretchCeilings.Domain.Models.RolePermission.PermissionId')
  - [Role](#P-StretchCeilings-Domain-Models-RolePermission-Role 'StretchCeilings.Domain.Models.RolePermission.Role')
  - [RoleId](#P-StretchCeilings-Domain-Models-RolePermission-RoleId 'StretchCeilings.Domain.Models.RolePermission.RoleId')
- [RoleRepository](#T-StretchCeilings-DataAccess-Repositories-RoleRepository 'StretchCeilings.DataAccess.Repositories.RoleRepository')
  - [FindById(id)](#M-StretchCeilings-DataAccess-Repositories-RoleRepository-FindById-System-Int32- 'StretchCeilings.DataAccess.Repositories.RoleRepository.FindById(System.Int32)')
  - [GetAll()](#M-StretchCeilings-DataAccess-Repositories-RoleRepository-GetAll 'StretchCeilings.DataAccess.Repositories.RoleRepository.GetAll')
- [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room')
  - [Area](#P-StretchCeilings-Domain-Models-Room-Area 'StretchCeilings.Domain.Models.Room.Area')
  - [Corners](#P-StretchCeilings-Domain-Models-Room-Corners 'StretchCeilings.Domain.Models.Room.Corners')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Room-DeletedDate 'StretchCeilings.Domain.Models.Room.DeletedDate')
  - [Estate](#P-StretchCeilings-Domain-Models-Room-Estate 'StretchCeilings.Domain.Models.Room.Estate')
  - [EstateId](#P-StretchCeilings-Domain-Models-Room-EstateId 'StretchCeilings.Domain.Models.Room.EstateId')
  - [Id](#P-StretchCeilings-Domain-Models-Room-Id 'StretchCeilings.Domain.Models.Room.Id')
  - [Plane](#P-StretchCeilings-Domain-Models-Room-Plane 'StretchCeilings.Domain.Models.Room.Plane')
  - [Type](#P-StretchCeilings-Domain-Models-Room-Type 'StretchCeilings.Domain.Models.Room.Type')
  - [Add()](#M-StretchCeilings-Domain-Models-Room-Add 'StretchCeilings.Domain.Models.Room.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-Room-Delete 'StretchCeilings.Domain.Models.Room.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-Room-Update 'StretchCeilings.Domain.Models.Room.Update')
- [RoomProperty](#T-StretchCeilings-Domain-Enums-RoomProperty 'StretchCeilings.Domain.Enums.RoomProperty')
- [RoomType](#T-StretchCeilings-Domain-Models-Enums-RoomType 'StretchCeilings.Domain.Models.Enums.RoomType')
- [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service')
  - [Ceiling](#P-StretchCeilings-Domain-Models-Service-Ceiling 'StretchCeilings.Domain.Models.Service.Ceiling')
  - [CeilingId](#P-StretchCeilings-Domain-Models-Service-CeilingId 'StretchCeilings.Domain.Models.Service.CeilingId')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-Service-DeletedDate 'StretchCeilings.Domain.Models.Service.DeletedDate')
  - [Id](#P-StretchCeilings-Domain-Models-Service-Id 'StretchCeilings.Domain.Models.Service.Id')
  - [Manufacturer](#P-StretchCeilings-Domain-Models-Service-Manufacturer 'StretchCeilings.Domain.Models.Service.Manufacturer')
  - [ManufacturerId](#P-StretchCeilings-Domain-Models-Service-ManufacturerId 'StretchCeilings.Domain.Models.Service.ManufacturerId')
  - [Price](#P-StretchCeilings-Domain-Models-Service-Price 'StretchCeilings.Domain.Models.Service.Price')
  - [Room](#P-StretchCeilings-Domain-Models-Service-Room 'StretchCeilings.Domain.Models.Service.Room')
  - [RoomId](#P-StretchCeilings-Domain-Models-Service-RoomId 'StretchCeilings.Domain.Models.Service.RoomId')
  - [Add()](#M-StretchCeilings-Domain-Models-Service-Add 'StretchCeilings.Domain.Models.Service.Add')
  - [CalculatePrice()](#M-StretchCeilings-Domain-Models-Service-CalculatePrice 'StretchCeilings.Domain.Models.Service.CalculatePrice')
  - [Delete()](#M-StretchCeilings-Domain-Models-Service-Delete 'StretchCeilings.Domain.Models.Service.Delete')
  - [GetAdditionalServices()](#M-StretchCeilings-Domain-Models-Service-GetAdditionalServices 'StretchCeilings.Domain.Models.Service.GetAdditionalServices')
  - [Update()](#M-StretchCeilings-Domain-Models-Service-Update 'StretchCeilings.Domain.Models.Service.Update')
- [ServiceAdditionalService](#T-StretchCeilings-Domain-Models-ServiceAdditionalService 'StretchCeilings.Domain.Models.ServiceAdditionalService')
  - [AdditionalService](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-AdditionalService 'StretchCeilings.Domain.Models.ServiceAdditionalService.AdditionalService')
  - [AdditionalServiceId](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-AdditionalServiceId 'StretchCeilings.Domain.Models.ServiceAdditionalService.AdditionalServiceId')
  - [Count](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-Count 'StretchCeilings.Domain.Models.ServiceAdditionalService.Count')
  - [Service](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-Service 'StretchCeilings.Domain.Models.ServiceAdditionalService.Service')
  - [ServiceId](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-ServiceId 'StretchCeilings.Domain.Models.ServiceAdditionalService.ServiceId')
  - [Add()](#M-StretchCeilings-Domain-Models-ServiceAdditionalService-Add 'StretchCeilings.Domain.Models.ServiceAdditionalService.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-ServiceAdditionalService-Delete 'StretchCeilings.Domain.Models.ServiceAdditionalService.Delete')
  - [GetAdditionalService()](#M-StretchCeilings-Domain-Models-ServiceAdditionalService-GetAdditionalService 'StretchCeilings.Domain.Models.ServiceAdditionalService.GetAdditionalService')
  - [Update()](#M-StretchCeilings-Domain-Models-ServiceAdditionalService-Update 'StretchCeilings.Domain.Models.ServiceAdditionalService.Update')
- [ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty')
- [SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption')
- [TextureType](#T-StretchCeilings-Domain-Models-Enums-TextureType 'StretchCeilings.Domain.Models.Enums.TextureType')
- [TimeTable](#T-StretchCeilings-Domain-Models-TimeTable 'StretchCeilings.Domain.Models.TimeTable')
  - [Date](#P-StretchCeilings-Domain-Models-TimeTable-Date 'StretchCeilings.Domain.Models.TimeTable.Date')
  - [DeletedDate](#P-StretchCeilings-Domain-Models-TimeTable-DeletedDate 'StretchCeilings.Domain.Models.TimeTable.DeletedDate')
  - [Employee](#P-StretchCeilings-Domain-Models-TimeTable-Employee 'StretchCeilings.Domain.Models.TimeTable.Employee')
  - [EmployeeId](#P-StretchCeilings-Domain-Models-TimeTable-EmployeeId 'StretchCeilings.Domain.Models.TimeTable.EmployeeId')
  - [Id](#P-StretchCeilings-Domain-Models-TimeTable-Id 'StretchCeilings.Domain.Models.TimeTable.Id')
  - [TimeEnd](#P-StretchCeilings-Domain-Models-TimeTable-TimeEnd 'StretchCeilings.Domain.Models.TimeTable.TimeEnd')
  - [TimeStart](#P-StretchCeilings-Domain-Models-TimeTable-TimeStart 'StretchCeilings.Domain.Models.TimeTable.TimeStart')
  - [Add()](#M-StretchCeilings-Domain-Models-TimeTable-Add 'StretchCeilings.Domain.Models.TimeTable.Add')
  - [Delete()](#M-StretchCeilings-Domain-Models-TimeTable-Delete 'StretchCeilings.Domain.Models.TimeTable.Delete')
  - [Update()](#M-StretchCeilings-Domain-Models-TimeTable-Update 'StretchCeilings.Domain.Models.TimeTable.Update')

<a name='T-StretchCeilings-Domain-Models-AdditionalService'></a>
## AdditionalService `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-AdditionalService-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-AdditionalService-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-AdditionalService-Name'></a>
### Name `property`

##### Summary

name

<a name='P-StretchCeilings-Domain-Models-AdditionalService-Price'></a>
### Price `property`

##### Summary

price

<a name='M-StretchCeilings-Domain-Models-AdditionalService-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-AdditionalService-CountInOrders-System-DateTime,System-DateTime-'></a>
### CountInOrders(dateFrom,dateUntil) `method`

##### Summary

Returns additional services count in order for same period

##### Returns

additional services count

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateFrom | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | date from |
| dateUntil | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | date until |

<a name='M-StretchCeilings-Domain-Models-AdditionalService-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-AdditionalService-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-AdditionalServiceProperty'></a>
## AdditionalServiceProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService') properties

<a name='T-StretchCeilings-Domain-Models-Ceiling'></a>
## Ceiling `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Ceiling-ColorType'></a>
### ColorType `property`

##### Summary

color type

<a name='P-StretchCeilings-Domain-Models-Ceiling-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Ceiling-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Ceiling-Manufacturer'></a>
### Manufacturer `property`

##### Summary

manufacturer

<a name='P-StretchCeilings-Domain-Models-Ceiling-ManufacturerId'></a>
### ManufacturerId `property`

##### Summary

manufacturer identifier

<a name='P-StretchCeilings-Domain-Models-Ceiling-Name'></a>
### Name `property`

##### Summary

name

<a name='P-StretchCeilings-Domain-Models-Ceiling-Price'></a>
### Price `property`

##### Summary

price

<a name='P-StretchCeilings-Domain-Models-Ceiling-TextureType'></a>
### TextureType `property`

##### Summary

texture type

<a name='M-StretchCeilings-Domain-Models-Ceiling-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Ceiling-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Ceiling-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-CeilingForm'></a>
## CeilingForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-CeilingForm-#ctor-StretchCeilings-Domain-Models-Ceiling-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-CeilingForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-CeilingForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-CeilingForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Enums-ColorType'></a>
## ColorType `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Color types of ceiling

<a name='T-StretchCeilings-Domain-Models-Enums-Country'></a>
## Country `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Countries of manufacturer

<a name='T-StretchCeilings-Domain-Models-Customer'></a>
## Customer `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Customer-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Customer-FullName'></a>
### FullName `property`

##### Summary

full name

<a name='P-StretchCeilings-Domain-Models-Customer-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Customer-PhoneNumber'></a>
### PhoneNumber `property`

##### Summary

phone number

<a name='M-StretchCeilings-Domain-Models-Customer-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Customer-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Customer-GetEstates'></a>
### GetEstates() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Customer-GetOrders'></a>
### GetOrders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Customer-GetOrdersCount-System-DateTime,System-DateTime-'></a>
### GetOrdersCount() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Customer-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-CustomerEditForm'></a>
## CustomerEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-CustomerEditForm-#ctor-StretchCeilings-Domain-Models-Customer-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-CustomerEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-CustomerEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-CustomerEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-CustomerForm'></a>
## CustomerForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-CustomerForm-#ctor-StretchCeilings-Domain-Models-Customer,StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-CustomerForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-CustomerForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-CustomerForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-CustomerProperty'></a>
## CustomerProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') properties

<a name='T-StretchCeilings-UI-Views-CustomersForm'></a>
## CustomersForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-CustomersForm-#ctor-StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-CustomersForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-CustomersForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-CustomersForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Employee'></a>
## Employee `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Employee-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Employee-FullName'></a>
### FullName `property`

##### Summary

full name

<a name='P-StretchCeilings-Domain-Models-Employee-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Employee-Login'></a>
### Login `property`

##### Summary

login

<a name='P-StretchCeilings-Domain-Models-Employee-Password'></a>
### Password `property`

##### Summary

password

<a name='P-StretchCeilings-Domain-Models-Employee-Role'></a>
### Role `property`

##### Summary

role

<a name='P-StretchCeilings-Domain-Models-Employee-RoleId'></a>
### RoleId `property`

##### Summary

role identifier

<a name='M-StretchCeilings-Domain-Models-Employee-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Employee-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Employee-GetSchedule'></a>
### GetSchedule() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Employee-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-EmployeeEditForm'></a>
## EmployeeEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-EmployeeEditForm-#ctor-StretchCeilings-Domain-Models-Employee-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-EmployeeEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-EmployeeEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-EmployeeEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-EmployeeForm'></a>
## EmployeeForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-EmployeeForm-#ctor-StretchCeilings-Domain-Models-Employee,StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-EmployeeForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-EmployeeForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-EmployeeForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-EmployeeProperty'></a>
## EmployeeProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') properties

<a name='T-StretchCeilings-UI-Views-EmployeesForm'></a>
## EmployeesForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-EmployeesForm-#ctor-StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-EmployeesForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-EmployeesForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-EmployeesForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Extensions-EnumExtensions'></a>
## EnumExtensions `type`

##### Namespace

StretchCeilings.Domain.Extensions

##### Summary

Presents extension for converting enums to string

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-ColorType-'></a>
### ParseString(colorType) `method`

##### Summary

Convert [ColorType](#T-StretchCeilings-Domain-Models-Enums-ColorType 'StretchCeilings.Domain.Models.Enums.ColorType') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [ColorType](#T-StretchCeilings-Domain-Models-Enums-ColorType 'StretchCeilings.Domain.Models.Enums.ColorType')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| colorType | [StretchCeilings.Domain.Models.Enums.ColorType](#T-StretchCeilings-Domain-Models-Enums-ColorType 'StretchCeilings.Domain.Models.Enums.ColorType') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-PermissionCode-'></a>
### ParseString(code) `method`

##### Summary

Convert [PermissionCode](#T-StretchCeilings-Domain-Models-Enums-PermissionCode 'StretchCeilings.Domain.Models.Enums.PermissionCode') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [PermissionCode](#T-StretchCeilings-Domain-Models-Enums-PermissionCode 'StretchCeilings.Domain.Models.Enums.PermissionCode')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [StretchCeilings.Domain.Models.Enums.PermissionCode](#T-StretchCeilings-Domain-Models-Enums-PermissionCode 'StretchCeilings.Domain.Models.Enums.PermissionCode') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-OrderStatus-'></a>
### ParseString(status) `method`

##### Summary

Convert [OrderStatus](#T-StretchCeilings-Domain-Models-Enums-OrderStatus 'StretchCeilings.Domain.Models.Enums.OrderStatus') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [OrderStatus](#T-StretchCeilings-Domain-Models-Enums-OrderStatus 'StretchCeilings.Domain.Models.Enums.OrderStatus')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| status | [StretchCeilings.Domain.Models.Enums.OrderStatus](#T-StretchCeilings-Domain-Models-Enums-OrderStatus 'StretchCeilings.Domain.Models.Enums.OrderStatus') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-TextureType-'></a>
### ParseString(textureType) `method`

##### Summary

Convert [TextureType](#T-StretchCeilings-Domain-Models-Enums-TextureType 'StretchCeilings.Domain.Models.Enums.TextureType') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [TextureType](#T-StretchCeilings-Domain-Models-Enums-TextureType 'StretchCeilings.Domain.Models.Enums.TextureType')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textureType | [StretchCeilings.Domain.Models.Enums.TextureType](#T-StretchCeilings-Domain-Models-Enums-TextureType 'StretchCeilings.Domain.Models.Enums.TextureType') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-RoomType-'></a>
### ParseString(type) `method`

##### Summary

Convert [RoomType](#T-StretchCeilings-Domain-Models-Enums-RoomType 'StretchCeilings.Domain.Models.Enums.RoomType') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [RoomType](#T-StretchCeilings-Domain-Models-Enums-RoomType 'StretchCeilings.Domain.Models.Enums.RoomType')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [StretchCeilings.Domain.Models.Enums.RoomType](#T-StretchCeilings-Domain-Models-Enums-RoomType 'StretchCeilings.Domain.Models.Enums.RoomType') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Models-Enums-Country-'></a>
### ParseString(type) `method`

##### Summary

Convert [Country](#T-StretchCeilings-Domain-Models-Enums-Country 'StretchCeilings.Domain.Models.Enums.Country') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [Country](#T-StretchCeilings-Domain-Models-Enums-Country 'StretchCeilings.Domain.Models.Enums.Country')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [StretchCeilings.Domain.Models.Enums.Country](#T-StretchCeilings-Domain-Models-Enums-Country 'StretchCeilings.Domain.Models.Enums.Country') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-OrderProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.OrderProperty](#T-StretchCeilings-Domain-Enums-OrderProperty 'StretchCeilings.Domain.Enums.OrderProperty') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-AdditionalServiceProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [AdditionalServiceProperty](#T-StretchCeilings-Domain-Enums-AdditionalServiceProperty 'StretchCeilings.Domain.Enums.AdditionalServiceProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [AdditionalServiceProperty](#T-StretchCeilings-Domain-Enums-AdditionalServiceProperty 'StretchCeilings.Domain.Enums.AdditionalServiceProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.AdditionalServiceProperty](#T-StretchCeilings-Domain-Enums-AdditionalServiceProperty 'StretchCeilings.Domain.Enums.AdditionalServiceProperty') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-CustomerProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [CustomerProperty](#T-StretchCeilings-Domain-Enums-CustomerProperty 'StretchCeilings.Domain.Enums.CustomerProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [CustomerProperty](#T-StretchCeilings-Domain-Enums-CustomerProperty 'StretchCeilings.Domain.Enums.CustomerProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.CustomerProperty](#T-StretchCeilings-Domain-Enums-CustomerProperty 'StretchCeilings.Domain.Enums.CustomerProperty') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-EmployeeProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [EmployeeProperty](#T-StretchCeilings-Domain-Enums-EmployeeProperty 'StretchCeilings.Domain.Enums.EmployeeProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [EmployeeProperty](#T-StretchCeilings-Domain-Enums-EmployeeProperty 'StretchCeilings.Domain.Enums.EmployeeProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.EmployeeProperty](#T-StretchCeilings-Domain-Enums-EmployeeProperty 'StretchCeilings.Domain.Enums.EmployeeProperty') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-ManufacturerProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [ManufacturerProperty](#T-StretchCeilings-Domain-Enums-ManufacturerProperty 'StretchCeilings.Domain.Enums.ManufacturerProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [ManufacturerProperty](#T-StretchCeilings-Domain-Enums-ManufacturerProperty 'StretchCeilings.Domain.Enums.ManufacturerProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.ManufacturerProperty](#T-StretchCeilings-Domain-Enums-ManufacturerProperty 'StretchCeilings.Domain.Enums.ManufacturerProperty') | source |

<a name='M-StretchCeilings-Domain-Extensions-EnumExtensions-ParseString-StretchCeilings-Domain-Enums-ServiceProperty-'></a>
### ParseString(property) `method`

##### Summary

Convert [ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty') to [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns

Converted [ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| property | [StretchCeilings.Domain.Enums.ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty') | source |

<a name='T-StretchCeilings-Domain-Models-Estate'></a>
## Estate `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Estate-Address'></a>
### Address `property`

##### Summary

address

<a name='P-StretchCeilings-Domain-Models-Estate-Customer'></a>
### Customer `property`

##### Summary

customer

<a name='P-StretchCeilings-Domain-Models-Estate-CustomerId'></a>
### CustomerId `property`

##### Summary

customer identifier

<a name='P-StretchCeilings-Domain-Models-Estate-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Estate-Id'></a>
### Id `property`

##### Summary

identifier

<a name='M-StretchCeilings-Domain-Models-Estate-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Estate-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Estate-GetRooms'></a>
### GetRooms() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Estate-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-EstateEditForm'></a>
## EstateEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-EstateEditForm-#ctor-StretchCeilings-Domain-Models-Estate-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-StretchCeilings-UI-Views-EstateEditForm-#ctor-StretchCeilings-Domain-Models-Customer-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-EstateEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-EstateEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-EstateEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-EstateForm'></a>
## EstateForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-EstateForm-#ctor-StretchCeilings-Domain-Models-Estate-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-EstateForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-EstateForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-EstateForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-Controls-FlatButton'></a>
## FlatButton `type`

##### Namespace

StretchCeilings.UI.Views.Controls

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-Controls-FlatButton-#ctor-System-String,System-String,System-EventHandler-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-StretchCeilings-UI-Views-FlatMessageBoxForm'></a>
## FlatMessageBoxForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-FlatMessageBoxForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-StretchCeilings-UI-Views-FlatMessageBoxForm-#ctor-System-String,System-String,StretchCeilings-UI-Views-Enums-MessageBoxState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-FlatMessageBoxForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-FlatMessageBoxForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-FlatMessageBoxForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Repositories-IAdditionalServiceRepository'></a>
## IAdditionalServiceRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of additional services

<a name='M-StretchCeilings-Domain-Repositories-IAdditionalServiceRepository-GetAll-StretchCeilings-Domain-Models-AdditionalService,StretchCeilings-Domain-Models-AdditionalService,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-AdditionalServiceProperty-'></a>
### GetAll(firstFilter,secondsFilter,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of additional services

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService') is a [AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| firstFilter | [StretchCeilings.Domain.Models.AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService') | first filter |
| secondsFilter | [StretchCeilings.Domain.Models.AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService') | second filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | additional services count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the additional services table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.AdditionalServiceProperty](#T-StretchCeilings-Domain-Enums-AdditionalServiceProperty 'StretchCeilings.Domain.Enums.AdditionalServiceProperty') | property of [AdditionalService](#T-StretchCeilings-Domain-Models-AdditionalService 'StretchCeilings.Domain.Models.AdditionalService') |

<a name='T-StretchCeilings-Domain-Services-IAuthService'></a>
## IAuthService `type`

##### Namespace

StretchCeilings.Domain.Services

##### Summary

Represents a services for authorization

<a name='M-StretchCeilings-Domain-Services-IAuthService-Login-System-String,System-String-'></a>
### Login(login,password) `method`

##### Summary

Tries to authorize a user

##### Returns

`true` if a user with the same username
and password exists in the database;
otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | user name |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | user password |

<a name='T-StretchCeilings-Domain-Models-Interfaces-ICustomer'></a>
## ICustomer `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetEstates'></a>
### GetEstates() `method`

##### Summary

Returns customers estates

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Estate](#T-StretchCeilings-Domain-Models-Estate 'StretchCeilings.Domain.Models.Estate')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetOrders'></a>
### GetOrders() `method`

##### Summary

Returns customer orders

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-ICustomer-GetOrdersCount-System-DateTime,System-DateTime-'></a>
### GetOrdersCount(dateFrom,dateUntil) `method`

##### Summary

Returns customer orders count for same period

##### Returns

customer orders count

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dateFrom | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | date from |
| dateUntil | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | date until |

<a name='T-StretchCeilings-Domain-Repositories-ICustomerRepository'></a>
## ICustomerRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of customers

<a name='M-StretchCeilings-Domain-Repositories-ICustomerRepository-GetAll-StretchCeilings-Domain-Models-Customer,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-CustomerProperty-'></a>
### GetAll(filter,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of customers

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') is a [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [StretchCeilings.Domain.Models.Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') | filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | customers count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the customers table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.CustomerProperty](#T-StretchCeilings-Domain-Enums-CustomerProperty 'StretchCeilings.Domain.Enums.CustomerProperty') | property of [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') |

<a name='T-StretchCeilings-Domain-Models-Interfaces-IDbModel'></a>
## IDbModel `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

Represents a database entity

<a name='M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Add'></a>
### Add() `method`

##### Summary

Add entity to a database

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Delete'></a>
### Delete() `method`

##### Summary

Delete entity from a database

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IDbModel-Update'></a>
### Update() `method`

##### Summary

Update entity in a database

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Interfaces-IEmployee'></a>
## IEmployee `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IEmployee-GetSchedule'></a>
### GetSchedule() `method`

##### Summary

Returns employee schedule

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [TimeTable](#T-StretchCeilings-Domain-Models-TimeTable 'StretchCeilings.Domain.Models.TimeTable')

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Repositories-IEmployeeRepository'></a>
## IEmployeeRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of employees

<a name='M-StretchCeilings-Domain-Repositories-IEmployeeRepository-FindByLogin-System-String-'></a>
### FindByLogin(login) `method`

##### Summary

Returns a employee with a specific login

##### Returns

[Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| login | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-StretchCeilings-Domain-Repositories-IEmployeeRepository-GetAll-StretchCeilings-Domain-Models-Employee,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-EmployeeProperty-'></a>
### GetAll(filter,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of employees

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') is a [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [StretchCeilings.Domain.Models.Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') | filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | employees count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the employees table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.EmployeeProperty](#T-StretchCeilings-Domain-Enums-EmployeeProperty 'StretchCeilings.Domain.Enums.EmployeeProperty') | property of [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') |

<a name='T-StretchCeilings-Domain-Models-Interfaces-IEstate'></a>
## IEstate `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IEstate-GetRooms'></a>
### GetRooms() `method`

##### Summary

Returns estate rooms

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room')

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Interfaces-IManufacturer'></a>
## IManufacturer `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IManufacturer-GetCeilings'></a>
### GetCeilings() `method`

##### Summary

Returns manufacturers ceilings

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Ceiling](#T-StretchCeilings-Domain-Models-Ceiling 'StretchCeilings.Domain.Models.Ceiling')

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Repositories-IManufacturerRepository'></a>
## IManufacturerRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of manufacturers

<a name='M-StretchCeilings-Domain-Repositories-IManufacturerRepository-GetAll-StretchCeilings-Domain-Models-Manufacturer,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-ManufacturerProperty-'></a>
### GetAll(filter,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of manufacturers

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') is a [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [StretchCeilings.Domain.Models.Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') | filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | manufacturers count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the manufacturers table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.ManufacturerProperty](#T-StretchCeilings-Domain-Enums-ManufacturerProperty 'StretchCeilings.Domain.Enums.ManufacturerProperty') | property of [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') |

<a name='T-StretchCeilings-Domain-Models-Interfaces-IOrder'></a>
## IOrder `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-CalculateTotal'></a>
### CalculateTotal() `method`

##### Summary

Calculate orders total price

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetEmployees'></a>
### GetEmployees() `method`

##### Summary

Returns orders employees

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetLogs'></a>
### GetLogs() `method`

##### Summary

Returns orders logs

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Log](#T-StretchCeilings-Domain-Models-Log 'StretchCeilings.Domain.Models.Log')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetServices'></a>
### GetServices() `method`

##### Summary

Returns orders services

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-GetWorkDates'></a>
### GetWorkDates() `method`

##### Summary

Returns orders work dates

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [OrderWorkDate](#T-StretchCeilings-Domain-Models-OrderWorkDate 'StretchCeilings.Domain.Models.OrderWorkDate')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-RemoveEmployee-System-Int32-'></a>
### RemoveEmployee(id) `method`

##### Summary

Remove employee from order

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | employee identifier |

<a name='M-StretchCeilings-Domain-Models-Interfaces-IOrder-RemoveService-System-Int32-'></a>
### RemoveService(id) `method`

##### Summary

Remove service from order

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | service identifier |

<a name='T-StretchCeilings-Domain-Repositories-IOrderRepository'></a>
## IOrderRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of orders

<a name='M-StretchCeilings-Domain-Repositories-IOrderRepository-GetAll-StretchCeilings-Domain-Models-Order,StretchCeilings-Domain-Models-Order,StretchCeilings-Domain-Models-Customer,StretchCeilings-Domain-Models-Employee,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-OrderProperty-'></a>
### GetAll(firstFilter,secondFilter,customer,employee,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of orders

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') is a [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| firstFilter | [StretchCeilings.Domain.Models.Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') | first filter |
| secondFilter | [StretchCeilings.Domain.Models.Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') | second filter |
| customer | [StretchCeilings.Domain.Models.Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') | third filter |
| employee | [StretchCeilings.Domain.Models.Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') | fourth filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | orders count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the orders table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.OrderProperty](#T-StretchCeilings-Domain-Enums-OrderProperty 'StretchCeilings.Domain.Enums.OrderProperty') | property of [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') |

<a name='T-StretchCeilings-Domain-IRepository`1'></a>
## IRepository\`1 `type`

##### Namespace

StretchCeilings.Domain

##### Summary

Represents a repository of database entities

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Database entity |

<a name='M-StretchCeilings-Domain-IRepository`1-FindById-System-Int32-'></a>
### FindById(id) `method`

##### Summary

Returns a database entity with a specific identifier

##### Returns

Database entity

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | entity identifier |

<a name='M-StretchCeilings-Domain-IRepository`1-GetAll'></a>
### GetAll() `method`

##### Summary

Returns database entities

##### Returns

Enumerable of database entities

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Interfaces-IRole'></a>
## IRole `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IRole-AddPermission-StretchCeilings-Domain-Models-Permission-'></a>
### AddPermission(permission) `method`

##### Summary

Add permission

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| permission | [StretchCeilings.Domain.Models.Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission') | entity of [Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission') |

<a name='M-StretchCeilings-Domain-Models-Interfaces-IRole-DeletePermission-StretchCeilings-Domain-Models-Permission-'></a>
### DeletePermission(permission) `method`

##### Summary

Delete permission

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| permission | [StretchCeilings.Domain.Models.Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission') | entity of [Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission') |

<a name='M-StretchCeilings-Domain-Models-Interfaces-IRole-GetPermissions'></a>
### GetPermissions() `method`

##### Summary

Returns roles permissions

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [Permission](#T-StretchCeilings-Domain-Models-Permission 'StretchCeilings.Domain.Models.Permission')

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Repositories-IRoleRepository'></a>
## IRoleRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represent a repository of roles

<a name='T-StretchCeilings-Domain-Repositories-IRoomRepository'></a>
## IRoomRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of customer rooms

<a name='M-StretchCeilings-Domain-Repositories-IRoomRepository-GetAll-StretchCeilings-Domain-Models-Customer,StretchCeilings-Domain-Models-Estate,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-RoomProperty-'></a>
### GetAll(customer,estate,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of customer rooms

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room') is a [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| customer | [StretchCeilings.Domain.Models.Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') | first filter |
| estate | [StretchCeilings.Domain.Models.Estate](#T-StretchCeilings-Domain-Models-Estate 'StretchCeilings.Domain.Models.Estate') | second filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | rooms count |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the rooms table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.RoomProperty](#T-StretchCeilings-Domain-Enums-RoomProperty 'StretchCeilings.Domain.Enums.RoomProperty') | property of [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room') |

<a name='T-StretchCeilings-Domain-Models-Interfaces-IService'></a>
## IService `type`

##### Namespace

StretchCeilings.Domain.Models.Interfaces

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-Domain-Models-Interfaces-IService-CalculatePrice'></a>
### CalculatePrice() `method`

##### Summary

Calculate service price

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Interfaces-IService-GetAdditionalServices'></a>
### GetAdditionalServices() `method`

##### Summary

Returns service additional services

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where T is [ServiceAdditionalService](#T-StretchCeilings-Domain-Models-ServiceAdditionalService 'StretchCeilings.Domain.Models.ServiceAdditionalService')

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Repositories-IServiceRepository'></a>
## IServiceRepository `type`

##### Namespace

StretchCeilings.Domain.Repositories

##### Summary

Represents a repository of services

<a name='M-StretchCeilings-Domain-Repositories-IServiceRepository-GetAll-StretchCeilings-Domain-Models-Service,StretchCeilings-Domain-Models-Service,System-Int32,System-Int32,StretchCeilings-Domain-Enums-SortOption,StretchCeilings-Domain-Enums-ServiceProperty-'></a>
### GetAll(firstFilter,secondFilter,count,page,option,property) `method`

##### Summary

Returns a filtered and ordered enumeration of services

##### Returns

[IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') where [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') is a [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| firstFilter | [StretchCeilings.Domain.Models.Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') | first filter |
| secondFilter | [StretchCeilings.Domain.Models.Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') | second filter |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | count of services |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | page number in the services table |
| option | [StretchCeilings.Domain.Enums.SortOption](#T-StretchCeilings-Domain-Enums-SortOption 'StretchCeilings.Domain.Enums.SortOption') | order option |
| property | [StretchCeilings.Domain.Enums.ServiceProperty](#T-StretchCeilings-Domain-Enums-ServiceProperty 'StretchCeilings.Domain.Enums.ServiceProperty') | property of service |

<a name='T-StretchCeilings-Domain-Models-Log'></a>
## Log `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Log-Comment'></a>
### Comment `property`

##### Summary

comment

<a name='P-StretchCeilings-Domain-Models-Log-DateCreated'></a>
### DateCreated `property`

##### Summary

created date

<a name='P-StretchCeilings-Domain-Models-Log-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Log-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Log-Order'></a>
### Order `property`

##### Summary

order

<a name='P-StretchCeilings-Domain-Models-Log-OrderId'></a>
### OrderId `property`

##### Summary

order identifier

<a name='M-StretchCeilings-Domain-Models-Log-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Log-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Log-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-LoginForm'></a>
## LoginForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-LoginForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-LoginForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-LoginForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-LoginForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-MainForm'></a>
## MainForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-MainForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-MainForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-MainForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-MainForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
 the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Manufacturer'></a>
## Manufacturer `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Manufacturer-Address'></a>
### Address `property`

##### Summary

address

<a name='P-StretchCeilings-Domain-Models-Manufacturer-Country'></a>
### Country `property`

##### Summary

country

<a name='P-StretchCeilings-Domain-Models-Manufacturer-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Manufacturer-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Manufacturer-Name'></a>
### Name `property`

##### Summary

name

<a name='M-StretchCeilings-Domain-Models-Manufacturer-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Manufacturer-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Manufacturer-GetCeilings'></a>
### GetCeilings() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Manufacturer-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-ManufacturerEditForm'></a>
## ManufacturerEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ManufacturerEditForm-#ctor-StretchCeilings-Domain-Models-Manufacturer-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ManufacturerEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ManufacturerEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ManufacturerEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-ManufacturerForm'></a>
## ManufacturerForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ManufacturerForm-#ctor-StretchCeilings-Domain-Models-Manufacturer,StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ManufacturerForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ManufacturerForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ManufacturerForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-ManufacturerProperty'></a>
## ManufacturerProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') properties

<a name='T-StretchCeilings-UI-Views-ManufacturersForm'></a>
## ManufacturersForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ManufacturersForm-#ctor-StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ManufacturersForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ManufacturersForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ManufacturersForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Helpers-ModelHelper'></a>
## ModelHelper `type`

##### Namespace

StretchCeilings.Domain.Helpers

##### Summary

Presents entity properties checker

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Manufacturer-'></a>
### HasNullField(manufacturer) `method`

##### Summary

Check [Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| manufacturer | [StretchCeilings.Domain.Models.Manufacturer](#T-StretchCeilings-Domain-Models-Manufacturer 'StretchCeilings.Domain.Models.Manufacturer') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Estate-'></a>
### HasNullField(estate) `method`

##### Summary

Check [Estate](#T-StretchCeilings-Domain-Models-Estate 'StretchCeilings.Domain.Models.Estate') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| estate | [StretchCeilings.Domain.Models.Estate](#T-StretchCeilings-Domain-Models-Estate 'StretchCeilings.Domain.Models.Estate') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Order-'></a>
### HasNullField(order) `method`

##### Summary

Check [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| order | [StretchCeilings.Domain.Models.Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Customer-'></a>
### HasNullField(customer) `method`

##### Summary

Check [Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| customer | [StretchCeilings.Domain.Models.Customer](#T-StretchCeilings-Domain-Models-Customer 'StretchCeilings.Domain.Models.Customer') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Employee-'></a>
### HasNullField(employee) `method`

##### Summary

Check [Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| employee | [StretchCeilings.Domain.Models.Employee](#T-StretchCeilings-Domain-Models-Employee 'StretchCeilings.Domain.Models.Employee') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Service-'></a>
### HasNullField(service) `method`

##### Summary

Check [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| service | [StretchCeilings.Domain.Models.Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') | source |

<a name='M-StretchCeilings-Domain-Helpers-ModelHelper-HasNullField-StretchCeilings-Domain-Models-Room-'></a>
### HasNullField(room) `method`

##### Summary

Check [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room') properties

##### Returns

`true` if some property is null; otherwise `false`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| room | [StretchCeilings.Domain.Models.Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room') | source |

<a name='T-StretchCeilings-Domain-Models-Order'></a>
## Order `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Order-Customer'></a>
### Customer `property`

##### Summary

customer

<a name='P-StretchCeilings-Domain-Models-Order-CustomerId'></a>
### CustomerId `property`

##### Summary

customer identifier

<a name='P-StretchCeilings-Domain-Models-Order-DateCanceled'></a>
### DateCanceled `property`

##### Summary

canceled date

<a name='P-StretchCeilings-Domain-Models-Order-DateOfMeasurements'></a>
### DateOfMeasurements `property`

##### Summary

measurements date

<a name='P-StretchCeilings-Domain-Models-Order-DatePaid'></a>
### DatePaid `property`

##### Summary

paid date

<a name='P-StretchCeilings-Domain-Models-Order-DatePlaced'></a>
### DatePlaced `property`

##### Summary

placed date

<a name='P-StretchCeilings-Domain-Models-Order-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Order-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Order-PaidByCash'></a>
### PaidByCash `property`

##### Summary

paid by cash

<a name='P-StretchCeilings-Domain-Models-Order-Status'></a>
### Status `property`

##### Summary

order status

<a name='P-StretchCeilings-Domain-Models-Order-Total'></a>
### Total `property`

##### Summary

total price

<a name='M-StretchCeilings-Domain-Models-Order-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-CalculateTotal'></a>
### CalculateTotal() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-GetEmployees'></a>
### GetEmployees() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-GetLogs'></a>
### GetLogs() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-GetServices'></a>
### GetServices() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-GetWorkDates'></a>
### GetWorkDates() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-RemoveEmployee-System-Int32-'></a>
### RemoveEmployee() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-RemoveService-System-Int32-'></a>
### RemoveService() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Order-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-OrderEditForm'></a>
## OrderEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-OrderEditForm-#ctor-StretchCeilings-Domain-Models-Order-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-OrderEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-OrderEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-OrderEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-OrderEmployee'></a>
## OrderEmployee `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-OrderEmployee-Employee'></a>
### Employee `property`

##### Summary

employee

<a name='P-StretchCeilings-Domain-Models-OrderEmployee-EmployeeId'></a>
### EmployeeId `property`

##### Summary

employee identifier

<a name='P-StretchCeilings-Domain-Models-OrderEmployee-Order'></a>
### Order `property`

##### Summary

order

<a name='P-StretchCeilings-Domain-Models-OrderEmployee-OrderId'></a>
### OrderId `property`

##### Summary

order identifier

<a name='M-StretchCeilings-Domain-Models-OrderEmployee-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderEmployee-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderEmployee-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-OrderForm'></a>
## OrderForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-OrderForm-#ctor-StretchCeilings-Domain-Models-Order,StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-OrderForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-OrderForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-OrderForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-OrderProperty'></a>
## OrderProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Order](#T-StretchCeilings-Domain-Models-Order 'StretchCeilings.Domain.Models.Order') properties

<a name='T-StretchCeilings-Domain-Models-OrderService'></a>
## OrderService `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-OrderService-Order'></a>
### Order `property`

##### Summary

order

<a name='P-StretchCeilings-Domain-Models-OrderService-OrderId'></a>
### OrderId `property`

##### Summary

order identifier

<a name='P-StretchCeilings-Domain-Models-OrderService-Service'></a>
### Service `property`

##### Summary

service

<a name='P-StretchCeilings-Domain-Models-OrderService-ServiceId'></a>
### ServiceId `property`

##### Summary

service identifier

<a name='M-StretchCeilings-Domain-Models-OrderService-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderService-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderService-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Enums-OrderStatus'></a>
## OrderStatus `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Statuses of order

<a name='T-StretchCeilings-Domain-Models-OrderWorkDate'></a>
## OrderWorkDate `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-OrderWorkDate-DateOfWork'></a>
### DateOfWork `property`

##### Summary

work date

<a name='P-StretchCeilings-Domain-Models-OrderWorkDate-Order'></a>
### Order `property`

##### Summary

order

<a name='P-StretchCeilings-Domain-Models-OrderWorkDate-OrderId'></a>
### OrderId `property`

##### Summary

order identifier

<a name='M-StretchCeilings-Domain-Models-OrderWorkDate-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderWorkDate-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-OrderWorkDate-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-OrderWorkDateForm'></a>
## OrderWorkDateForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-OrderWorkDateForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-OrderWorkDateForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-OrderWorkDateForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-OrderWorkDateForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-OrdersForm'></a>
## OrdersForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-OrdersForm-#ctor-StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-OrdersForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-OrdersForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-OrdersForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Permission'></a>
## Permission `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Permission-Code'></a>
### Code `property`

##### Summary

permission code

<a name='P-StretchCeilings-Domain-Models-Permission-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Permission-Name'></a>
### Name `property`

##### Summary

name

<a name='M-StretchCeilings-Domain-Models-Permission-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Permission-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Permission-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Enums-PermissionCode'></a>
## PermissionCode `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Codes of permissions

<a name='T-StretchCeilings-Properties-Resources'></a>
## Resources `type`

##### Namespace

StretchCeilings.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='T-StretchCeilings-UI-Structs-Resources'></a>
## Resources `type`

##### Namespace

StretchCeilings.UI.Structs

##### Summary



<a name='P-StretchCeilings-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-StretchCeilings-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-StretchCeilings-Properties-Resources-error_32x32'></a>
### error_32x32 `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='T-StretchCeilings-Domain-Models-Role'></a>
## Role `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Role-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Role-Name'></a>
### Name `property`

##### Summary

name

<a name='M-StretchCeilings-Domain-Models-Role-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Role-AddPermission-StretchCeilings-Domain-Models-Permission-'></a>
### AddPermission() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Role-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Role-DeletePermission-StretchCeilings-Domain-Models-Permission-'></a>
### DeletePermission() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Role-GetPermissions'></a>
### GetPermissions() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Role-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-RolePermission'></a>
## RolePermission `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

Presents database entity

<a name='P-StretchCeilings-Domain-Models-RolePermission-Permission'></a>
### Permission `property`

##### Summary

permission

<a name='P-StretchCeilings-Domain-Models-RolePermission-PermissionId'></a>
### PermissionId `property`

##### Summary

permission identifier

<a name='P-StretchCeilings-Domain-Models-RolePermission-Role'></a>
### Role `property`

##### Summary

role

<a name='P-StretchCeilings-Domain-Models-RolePermission-RoleId'></a>
### RoleId `property`

##### Summary

role identifier

<a name='T-StretchCeilings-DataAccess-Repositories-RoleRepository'></a>
## RoleRepository `type`

##### Namespace

StretchCeilings.DataAccess.Repositories

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-DataAccess-Repositories-RoleRepository-FindById-System-Int32-'></a>
### FindById(id) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| id | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-StretchCeilings-DataAccess-Repositories-RoleRepository-GetAll'></a>
### GetAll() `method`

##### Summary



##### Returns



##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Room'></a>
## Room `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Room-Area'></a>
### Area `property`

##### Summary

area

<a name='P-StretchCeilings-Domain-Models-Room-Corners'></a>
### Corners `property`

##### Summary

corners

<a name='P-StretchCeilings-Domain-Models-Room-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Room-Estate'></a>
### Estate `property`

##### Summary

estate

<a name='P-StretchCeilings-Domain-Models-Room-EstateId'></a>
### EstateId `property`

##### Summary

estate identifier

<a name='P-StretchCeilings-Domain-Models-Room-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Room-Plane'></a>
### Plane `property`

##### Summary

plane path

<a name='P-StretchCeilings-Domain-Models-Room-Type'></a>
### Type `property`

##### Summary

type

<a name='M-StretchCeilings-Domain-Models-Room-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Room-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Room-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-RoomEditForm'></a>
## RoomEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-RoomEditForm-#ctor-StretchCeilings-Domain-Models-Estate-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-RoomEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-RoomEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-RoomEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-RoomForm'></a>
## RoomForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-RoomForm-#ctor-StretchCeilings-Domain-Models-Room-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-RoomForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-RoomForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-RoomForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-RoomProperty'></a>
## RoomProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Room](#T-StretchCeilings-Domain-Models-Room 'StretchCeilings.Domain.Models.Room') properties

<a name='T-StretchCeilings-Domain-Models-Enums-RoomType'></a>
## RoomType `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Types of room

<a name='T-StretchCeilings-UI-Views-RoomsForm'></a>
## RoomsForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-RoomsForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-RoomsForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-RoomsForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-RoomsForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Service'></a>
## Service `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-Service-Ceiling'></a>
### Ceiling `property`

##### Summary

ceiling

<a name='P-StretchCeilings-Domain-Models-Service-CeilingId'></a>
### CeilingId `property`

##### Summary

ceiling identifier

<a name='P-StretchCeilings-Domain-Models-Service-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-Service-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-Service-Manufacturer'></a>
### Manufacturer `property`

##### Summary

manufacturer

<a name='P-StretchCeilings-Domain-Models-Service-ManufacturerId'></a>
### ManufacturerId `property`

##### Summary

manufacturer identifier

<a name='P-StretchCeilings-Domain-Models-Service-Price'></a>
### Price `property`

##### Summary

price

<a name='P-StretchCeilings-Domain-Models-Service-Room'></a>
### Room `property`

##### Summary

room

<a name='P-StretchCeilings-Domain-Models-Service-RoomId'></a>
### RoomId `property`

##### Summary

room identifier

<a name='M-StretchCeilings-Domain-Models-Service-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Service-CalculatePrice'></a>
### CalculatePrice() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Service-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Service-GetAdditionalServices'></a>
### GetAdditionalServices() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-Service-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-ServiceAdditionalService'></a>
## ServiceAdditionalService `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

Presents database entity

<a name='P-StretchCeilings-Domain-Models-ServiceAdditionalService-AdditionalService'></a>
### AdditionalService `property`

##### Summary

additional service

<a name='P-StretchCeilings-Domain-Models-ServiceAdditionalService-AdditionalServiceId'></a>
### AdditionalServiceId `property`

##### Summary

additional service identifier

<a name='P-StretchCeilings-Domain-Models-ServiceAdditionalService-Count'></a>
### Count `property`

##### Summary

additional service count

<a name='P-StretchCeilings-Domain-Models-ServiceAdditionalService-Service'></a>
### Service `property`

##### Summary

service

<a name='P-StretchCeilings-Domain-Models-ServiceAdditionalService-ServiceId'></a>
### ServiceId `property`

##### Summary

service identifier

<a name='M-StretchCeilings-Domain-Models-ServiceAdditionalService-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-ServiceAdditionalService-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-ServiceAdditionalService-GetAdditionalService'></a>
### GetAdditionalService() `method`

##### Summary

Returns additional service

##### Returns

[AdditionalService](#P-StretchCeilings-Domain-Models-ServiceAdditionalService-AdditionalService 'StretchCeilings.Domain.Models.ServiceAdditionalService.AdditionalService')

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-ServiceAdditionalService-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-ServiceEditForm'></a>
## ServiceEditForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ServiceEditForm-#ctor-StretchCeilings-Domain-Models-Service-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ServiceEditForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ServiceEditForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ServiceEditForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-ServiceForm'></a>
## ServiceForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ServiceForm-#ctor-StretchCeilings-Domain-Models-Service,StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ServiceForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ServiceForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ServiceForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-ServiceProperty'></a>
## ServiceProperty `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Service](#T-StretchCeilings-Domain-Models-Service 'StretchCeilings.Domain.Models.Service') properties

<a name='T-StretchCeilings-UI-Views-ServicesForm'></a>
## ServicesForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-ServicesForm-#ctor-StretchCeilings-UI-Views-Enums-FormState-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-ServicesForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-ServicesForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-ServicesForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Enums-SortOption'></a>
## SortOption `type`

##### Namespace

StretchCeilings.Domain.Enums

##### Summary

Presents [Repository\`1](#T-StretchCeilings-DataAccess-Repositories-Repository`1 'StretchCeilings.DataAccess.Repositories.Repository`1') sort option

<a name='T-StretchCeilings-UI-Views-StatisticsForm'></a>
## StatisticsForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-StatisticsForm-#ctor'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-StatisticsForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-StatisticsForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-StatisticsForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-Domain-Models-Enums-TextureType'></a>
## TextureType `type`

##### Namespace

StretchCeilings.Domain.Models.Enums

##### Summary

Texture types of ceiling

<a name='T-StretchCeilings-Domain-Models-TimeTable'></a>
## TimeTable `type`

##### Namespace

StretchCeilings.Domain.Models

##### Summary

*Inherit from parent.*

<a name='P-StretchCeilings-Domain-Models-TimeTable-Date'></a>
### Date `property`

##### Summary

work date

<a name='P-StretchCeilings-Domain-Models-TimeTable-DeletedDate'></a>
### DeletedDate `property`

##### Summary

deleted date

<a name='P-StretchCeilings-Domain-Models-TimeTable-Employee'></a>
### Employee `property`

##### Summary

employees

<a name='P-StretchCeilings-Domain-Models-TimeTable-EmployeeId'></a>
### EmployeeId `property`

##### Summary

employees identifier

<a name='P-StretchCeilings-Domain-Models-TimeTable-Id'></a>
### Id `property`

##### Summary

identifier

<a name='P-StretchCeilings-Domain-Models-TimeTable-TimeEnd'></a>
### TimeEnd `property`

##### Summary

end shift time

<a name='P-StretchCeilings-Domain-Models-TimeTable-TimeStart'></a>
### TimeStart `property`

##### Summary

start shift time

<a name='M-StretchCeilings-Domain-Models-TimeTable-Add'></a>
### Add() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-TimeTable-Delete'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-StretchCeilings-Domain-Models-TimeTable-Update'></a>
### Update() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-StretchCeilings-UI-Views-TimeTableForm'></a>
## TimeTableForm `type`

##### Namespace

StretchCeilings.UI.Views

##### Summary

*Inherit from parent.*

<a name='M-StretchCeilings-UI-Views-TimeTableForm-#ctor-StretchCeilings-Domain-Models-Employee-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='F-StretchCeilings-UI-Views-TimeTableForm-components'></a>
### components `constants`

##### Summary

Required designer variable.

<a name='M-StretchCeilings-UI-Views-TimeTableForm-Dispose-System-Boolean-'></a>
### Dispose(disposing) `method`

##### Summary

Clean up any resources being used.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| disposing | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if managed resources should be disposed; otherwise, false. |

<a name='M-StretchCeilings-UI-Views-TimeTableForm-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

Required method for Designer support - do not modify
the contents of this method with the code editor.

##### Parameters

This method has no parameters.
