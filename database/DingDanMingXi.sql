/*
*Name: [DingDanMingXi_Add]
*Description: 添加
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanMingXi_Add]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanMingXi_Add]
GO
CREATE procedure [DingDanMingXi_Add]
@D_SuoShuDingDanSN int,
@D_SuoShuBuMenSN int,
@D_SuoShuXiTongSN int,
@D_SuoShuFangJianTian int,
@D_SuoShuChuangWeiTian int,
@D_AddDate datetime,
@D_ShiFouShanChu bit
AS
Insert into DingDanMingXi
(
D_SuoShuDingDanSN,
D_SuoShuBuMenSN,
D_SuoShuXiTongSN,
D_SuoShuFangJianTian,
D_SuoShuChuangWeiTian,
D_AddDate,
D_ShiFouShanChu
)
Values
(
@D_SuoShuDingDanSN,
@D_SuoShuBuMenSN,
@D_SuoShuXiTongSN,
@D_SuoShuFangJianTian,
@D_SuoShuChuangWeiTian,
@D_AddDate,
@D_ShiFouShanChu
);
select SCOPE_IDENTITY();




/*
*Name: [DingDanMingXi_Delete]
*Description: 删除
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanMingXi_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanMingXi_Delete]
GO
CREATE procedure [DingDanMingXi_Delete]
@D_SN int
AS
Delete from DingDanMingXi where D_SN=@D_SN




/*
*Name: [DingDanMingXi_Get]
*Description: 获取
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanMingXi_Get]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanMingXi_Get]
GO
CREATE procedure [DingDanMingXi_Get]
@D_SN int
AS
select top 1 * from DingDanMingXi where D_SN=@D_SN




/*
*Name: [DingDanMingXi_List]
*Description: 列表
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanMingXi_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanMingXi_List]
GO
CREATE procedure [DingDanMingXi_List]
AS
select * from DingDanMingXi




/*
*Name: [DingDanMingXi_Set]
*Description: 设置
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[DingDanMingXi_Set]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [DingDanMingXi_Set]
GO
CREATE procedure [DingDanMingXi_Set]
@D_SN int,
@D_SuoShuDingDanSN int,
@D_SuoShuBuMenSN int,
@D_SuoShuXiTongSN int,
@D_SuoShuFangJianTian int,
@D_SuoShuChuangWeiTian int,
@D_AddDate datetime,
@D_ShiFouShanChu bit
AS
update DingDanMingXi Set
D_SuoShuDingDanSN=@D_SuoShuDingDanSN,
D_SuoShuBuMenSN=@D_SuoShuBuMenSN,
D_SuoShuXiTongSN=@D_SuoShuXiTongSN,
D_SuoShuFangJianTian=@D_SuoShuFangJianTian,
D_SuoShuChuangWeiTian=@D_SuoShuChuangWeiTian,
D_AddDate=@D_AddDate,
D_ShiFouShanChu=@D_ShiFouShanChu
where D_SN=@D_SN
