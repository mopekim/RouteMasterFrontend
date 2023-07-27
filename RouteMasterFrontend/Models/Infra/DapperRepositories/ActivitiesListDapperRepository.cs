﻿using Dapper;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using RouteMasterFrontend.Models.Dto;
using RouteMasterFrontend.Models.Infra.Criterias;
using RouteMasterFrontend.Models.Interfaces;

namespace RouteMasterFrontend.Models.Infra.DapperRepositories
{
	public class ActivitiesListDapperRepository:IActivityRepository
	{
		private readonly string _connstr;
        private readonly IConfiguration _configuration;

        public ActivitiesListDapperRepository(IConfiguration configuration )
        {
            _configuration = configuration;
			_connstr = _configuration.GetConnectionString("RouteMaster");
		}

		public IEnumerable<ActivityListDto> Search(ActivityListCriteria criteria)
		{
			using (var conn = new SqlConnection( _connstr))
			{
				string sql = @"SELECT 
AC.Id,Regions.[Name] as RegionName, 
ActivityCategories.[Name] as ActivityCategoryName , 
AC.[Name] as [Name], ATT.[Name] as [AttractionName],
AC.[Description] as [Description], AC.[Status] as [Status], 
AC.[Image] as [Image]
FROM Activities as AC
JOIN ActivityCategories 
ON AC.ActivityCategoryId=ActivityCategories.Id
JOIN Regions
ON AC.RegionId=Regions.Id
JOIN Attractions as ATT
ON AC.AttractionId=ATT.Id
";
				return conn.Query<ActivityListDto>(sql);
			}
		}
	}
}
