﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
	public class AboutManager : IAboutService
	{
		IAboutDal _aboutDal;
		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public List<About> GetList()
		{
			return _aboutDal.GetListAll();
		}
	}
}
