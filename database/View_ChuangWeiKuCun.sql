
/*
*Name: [View_ChuangWeiKuCun_List]
*Description: ап╠М
*Author: C#
*/
IF EXISTS (SELECT NAME FROM sysobjects WHERE id = OBJECT_ID(N'[View_ChuangWeiKuCun_List]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [View_ChuangWeiKuCun_List]
GO
CREATE procedure [View_ChuangWeiKuCun_List]
AS
select * from View_ChuangWeiKuCun


