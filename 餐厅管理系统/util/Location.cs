using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

/**
 * 本类实现有关地理位置信息的内容
 */
namespace 餐厅管理系统.util
{
    internal class Location
    {
         public static List<double> GetLocationProperty()
         {
            double latitude;
            double longitude;
            // 创建一个 List 来保存位置信息
            List<double> location = new List<double>();
            using (GeoCoordinateWatcher watcher = new GeoCoordinateWatcher())
            {

                if (watcher.Permission == GeoPositionPermission.Granted)
                {
                    // Do not suppress prompt, and wait 1000 milliseconds to start.
                    watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

                    GeoCoordinate coord = watcher.Position.Location;

                    if (coord.IsUnknown != true)
                    {
                        location.Add(coord.Latitude);
                        location.Add(coord.Longitude);
                        return location;
                    }
                    else
                    {
                        //Console.WriteLine("Unknown latitude and longitude.");
                        MessageBox.Show(watcher.Status.ToString());
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("需要位置权限以获取地理位置信息。请在设置中启用位置服务。");
                    return null;
                }
            }
         }
    }
}
