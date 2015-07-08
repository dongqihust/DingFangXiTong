/*
*Name: [DingDan_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDan_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDan_Add]
GO
CREATE procedure [DingDan_Add]
@D_SuoShuBuMenSN int,
@D_SuoShuXiTongSN int,
@D_TiJiaoRenName nvarchar(50),
@D_TiJiaoRenSN int,
@D_TiJiaoSuoShuBanJiSN int,
@D_TiJiaoRenKaoShiHao nvarchar(50),
@D_AddDate datetime,
@D_AddIP nvarchar(100),
@D_LianXiRen nvarchar(50),
@D_LianXiPhone nvarchar(20),
@D_LianXiMail nvarchar(50),
@D_Style int,
@D_JiaGe float,
@D_ZhuangTai int,
@D_ShiFouShanChu bit
AS
Insert into DingDan
(
D_SuoShuBuMenSN,
D_SuoShuXiTongSN,
D_TiJiaoRenName,
D_TiJiaoRenSN,
D_TiJiaoSuoShuBanJiSN,
D_TiJiaoRenKaoShiHao,
D_AddDate,
D_AddIP,
D_LianXiRen,
D_LianXiPhone,
D_LianXiMail,
D_Style,
D_JiaGe,
D_ZhuangTai,
D_ShiFouShanChu
)
Values
(
@D_SuoShuBuMenSN,
@D_SuoShuXiTongSN,
@D_TiJiaoRenName,
@D_TiJiaoRenSN,
@D_TiJiaoSuoShuBanJiSN,
@D_TiJiaoRenKaoShiHao,
@D_AddDate,
@D_AddIP,
@D_LianXiRen,
@D_LianXiPhone,
@D_LianXiMail,
@D_Style,
@D_JiaGe,
@D_ZhuangTai,
@D_ShiFouShanChu
)




/*
*Name: [DingDan_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDan_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDan_Delete]
GO
CREATE procedure [DingDan_Delete]
@D_SN int
AS
Delete from DingDan where D_SN=@D_SN




/*
*Name: [DingDan_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDan_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDan_Get]
GO
CREATE procedure [DingDan_Get]
@D_SN int
AS
select top 1 * from DingDan where D_SN=@D_SN




/*
*Name: [DingDan_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDan_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDan_List]
GO
CREATE procedure [DingDan_List]
AS
select * from DingDan




/*
*Name: [DingDan_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDan_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDan_Set]
GO
CREATE procedure [DingDan_Set]
@D_SN int,
@D_SuoShuBuMenSN int,
@D_SuoShuXiTongSN int,
@D_TiJiaoRenName nvarchar(50),
@D_TiJiaoRenSN int,
@D_TiJiaoSuoShuBanJiSN int,
@D_TiJiaoRenKaoShiHao nvarchar(50),
@D_AddDate datetime,
@D_AddIP nvarchar(100),
@D_LianXiRen nvarchar(50),
@D_LianXiPhone nvarchar(20),
@D_LianXiMail nvarchar(50),
@D_Style int,
@D_JiaGe float,
@D_ZhuangTai int,
@D_ShiFouShanChu bit
AS
update DingDan Set
D_SuoShuBuMenSN=@D_SuoShuBuMenSN,
D_SuoShuXiTongSN=@D_SuoShuXiTongSN,
D_TiJiaoRenName=@D_TiJiaoRenName,
D_TiJiaoRenSN=@D_TiJiaoRenSN,
D_TiJiaoSuoShuBanJiSN=@D_TiJiaoSuoShuBanJiSN,
D_TiJiaoRenKaoShiHao=@D_TiJiaoRenKaoShiHao,
D_AddDate=@D_AddDate,
D_AddIP=@D_AddIP,
D_LianXiRen=@D_LianXiRen,
D_LianXiPhone=@D_LianXiPhone,
D_LianXiMail=@D_LianXiMail,
D_Style=@D_Style,
D_JiaGe=@D_JiaGe,
D_ZhuangTai=@D_ZhuangTai,
D_ShiFouShanChu=@D_ShiFouShanChu
where D_SN=@D_SN
