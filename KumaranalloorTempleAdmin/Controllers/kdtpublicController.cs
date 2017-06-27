using kumaranalloordevitempleadminweb.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace kumaranalloordevitempleadminweb.Controllers
{
    public class kdtpublicController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/vazhipadu")]
        public List<Vazhipadu2ViewModel> lstVazhipadu(string diety)
        {
            VazhipaduController ctlVazhipadu = new VazhipaduController();
            List<Vazhipadu2ViewModel> lstVazhipaduVMResults = new List<Vazhipadu2ViewModel>();
            List <Vazhipadu> lstVazhipadu = ctlVazhipadu.List(diety);
            foreach (var vazhipadu in lstVazhipadu)
            {
                Vazhipadu2ViewModel vmVazhipadu = new Vazhipadu2ViewModel();
                vmVazhipadu.diety_name = vazhipadu.Diety.diety_name;
                vmVazhipadu.offering_name = vazhipadu.offering_name;
                vmVazhipadu.materials_reqd = vazhipadu.materials_reqd;
                vmVazhipadu.offering_amount = vazhipadu.offering_amount;
                vmVazhipadu.remarks = vazhipadu.remarks;

                lstVazhipaduVMResults.Add(vmVazhipadu);
            }
            return lstVazhipaduVMResults;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/notifications")]
        public List<Notifications2ViewModel> lstNotifications()
        {
            NotificationsController ctlNotifications = new NotificationsController();
            List<Notifications2ViewModel> lstNotificationsVMResults = new List<Notifications2ViewModel>();
            List<Notification> lstNotifications = ctlNotifications.List();
            foreach (var notification in lstNotifications)
            {
                Notifications2ViewModel vmNotifications = new Notifications2ViewModel();
                vmNotifications.notification_title = notification.notification_title;
                vmNotifications.notification_description = notification.notification_description;

                lstNotificationsVMResults.Add(vmNotifications);
            }
            return lstNotificationsVMResults;
        }
    }
}
