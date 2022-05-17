using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanitariumProject
{
    class Manager
    {
        internal object GetAllDepartment()
        {
            var context = new SANITARIUMEntities();
            var q = from dip in context.DepartmentInfoes select dip;
            return q.ToList();
        }

        internal object GetAllGroupt()
        {
            var context = new SANITARIUMEntities();
            var q = from grp in context.GroupInfoes select grp;
            return q.ToList();
        }

        internal object GetAllCategory()
        {
            var context = new SANITARIUMEntities();
            var q = from Cat in context.CategoryInfoes select Cat;
            return q.ToList();
        }

        internal object GettAllCategory()
        {
            var context = new SANITARIUMEntities();
            var q = from SubCat in context.CategoryInfoes select SubCat;
            return q.ToList();
        }

        internal object GetAllSpecimenName()
        {
            var context = new SANITARIUMEntities();
            var q = from Speci in context.SpecimenInfoes select Speci;
            return q.ToList();
        }

        internal List<SP_ALL_TEST_NAME_Result> GetAllGrid()
        {
            var context = new SANITARIUMEntities();
            var q = context.SP_ALL_TEST_NAME();
            return q.ToList();
        }

        internal object GetAllGender()
        {
            var context = new SANITARIUMEntities();
            var q = from Gndr in context.GenderInfoes select Gndr;
            return q.ToList();
        }

        internal object GetAllAgeStatus()
        {
            var context = new SANITARIUMEntities();
            var q = from AgS in context.AgeStatusInfoes select AgS;
            return q.ToList();
        }

        internal object GetAllDoctor()
        {
            var context = new SANITARIUMEntities();
            var q = from Dr in context.DoctorInfoes select Dr;
            return q.ToList();
        }

        internal object GetAllRefer()
        {
            var context = new SANITARIUMEntities();
            var q = from Ref in context.ReferInfoes select Ref;
            return q.ToList();
        }

        internal object GetAllTest()
        {
            var context = new SANITARIUMEntities();
            var q = from TS in context.DignosticTestDetails select TS;
            return q.ToList();
        }

        internal object GetAllDisAuthor()
        {
            var context = new SANITARIUMEntities();
            var q = from DisA in context.DiscountAuthorityInfoes 
                    select DisA;
            return q.ToList();
        }

        internal object GettAllDoctors()
        {
            var context = new SANITARIUMEntities();
            var q = from Doct in context.DoctorInfoes select Doct;
            return q.ToList();
        }
        
    }
}
