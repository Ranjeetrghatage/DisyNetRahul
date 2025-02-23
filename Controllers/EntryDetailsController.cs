using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using DisynetSoftware.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;


namespace DisynetSoftware.Controllers
{
    public class EntryDetailsController : Controller
    {
        private readonly string _connectionString;
        private readonly string _db;



        public EntryDetailsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Submit(DisynetDataModel model)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO disynetdata 
                (objectType, objectName, errorDescription, serialNumber, modelNo, capacity, 
                 inputResistance, outputResistance, excitationVoltage, initialUnbalance, 
                 loadingDevice, sensitivity, indicatorReference, maxNonlinearity, xiAvg, yiAvg, 
                 realError, date, time, blankNo, tonnes, sensorRange, remark, jobOrder, customer, 
                 verifiedBy, testedBy, division, tempDrift, E1, E2, E3, E4, E5, E6, E7, E8, E9, E10, E11, 
                 X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, X11, Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9, Y10, Y11) 
                VALUES 
                (@objectType, @objectName, @errorDescription, @serialNumber, @modelNo, @capacity, 
                 @inputResistance, @outputResistance, @excitationVoltage, @initialUnbalance, 
                 @loadingDevice, @sensitivity, @indicatorReference, @maxNonlinearity, @xiAvg, @yiAvg, 
                 @realError, @date, @time, @blankNo, @tonnes, @sensorRange, @remark, @jobOrder, @customer, 
                 @verifiedBy, @testedBy, @division, @tempDrift, @E1, @E2, @E3, @E4, @E5, @E6, @E7, @E8, @E9, @E10, @E11, 
                 @X1, @X2, @X3, @X4, @X5, @X6, @X7, @X8, @X9, @X10, @X11, @Y1, @Y2, @Y3, @Y4, @Y5, @Y6, @Y7, @Y8, @Y9, @Y10, @Y11)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@objectType", model.ObjectType ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@objectName", model.ObjectName ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@errorDescription", model.ErrorDescription ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@serialNumber", model.SerialNumber ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@modelNo", model.ModelNo ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@capacity", model.Capacity ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@inputResistance", model.InputResistance ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@outputResistance", model.OutputResistance ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@excitationVoltage", model.ExcitationVoltage ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@initialUnbalance", model.InitialUnbalance ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@loadingDevice", model.LoadingDevice ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@sensitivity", model.Sensitivity ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@indicatorReference", model.IndicatorReference ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@maxNonlinearity", model.MaxNonlinearity ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@xiAvg", model.XiAvg ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@yiAvg", model.YiAvg ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@realError", model.RealError ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@date", model.Date ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@time", model.Time ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@blankNo", model.BlankNo ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@tonnes", model.Tonnes ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@sensorRange", model.SensorRange ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@remark", model.Remark ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@jobOrder", model.JobOrder ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@customer", model.Customer ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@verifiedBy", model.VerifiedBy ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@testedBy", model.TestedBy ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@division", model.Division ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@tempDrift", model.TempDrift ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E1", model.E1 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E2", model.E2 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E3", model.E3 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E4", model.E4 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E5", model.E5 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E6", model.E6 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E7", model.E7 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E8", model.E8 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E9", model.E9 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E10", model.E10 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@E11", model.E11 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X1", model.X1 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X2", model.X2 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X3", model.X3 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X4", model.X4 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X5", model.X5 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X6", model.X6 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X7", model.X7 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X8", model.X8 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X9", model.X9 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X10", model.X10 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@X11", model.X11 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y1", model.Y1 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y2", model.Y2 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y3", model.Y3 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y4", model.Y4 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y5", model.Y5 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y6", model.Y6 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y7", model.Y7 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y8", model.Y8 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y9", model.Y9 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y10", model.Y10 ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Y11", model.Y11 ?? (object)DBNull.Value);

                        // Repeat for all other properties...
                        command.ExecuteNonQuery();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Create and pass an ErrorViewModel to the Error view


                return View("Error", ex);
            }
        }
        [HttpGet]
        [HttpPost]

        [HttpGet]
        public IActionResult OnTextChanged(string SearchText)
        {
            return FetchData(SearchText);
        }



        public IActionResult FetchData(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber))
            {
                return BadRequest("serial number is required.");
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM disynetdata WHERE serialNumber = @serialNumber";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@serialNumber", serialNumber);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Fetch all data from the database and return it as a JSON object
                                var data = new
                                {
                                    ObjectType = reader["objectType"]?.ToString(),
                                    ObjectName = reader["objectName"]?.ToString(),
                                    ErrorDescription = reader["errorDescription"]?.ToString(),
                                    SerialNumber = reader["serialNumber"]?.ToString(),
                                    ModelNo = reader["modelNo"]?.ToString(),
                                    Capacity = reader["capacity"]?.ToString(),
                                    InputResistance = reader["inputResistance"]?.ToString(),
                                    OutputResistance = reader["outputResistance"]?.ToString(),
                                    ExcitationVoltage = reader["excitationVoltage"]?.ToString(),
                                    InitialUnbalance = reader["initialUnbalance"]?.ToString(),
                                    LoadingDevice = reader["loadingDevice"]?.ToString(),
                                    Sensitivity = reader["sensitivity"]?.ToString(),
                                    IndicatorReference = reader["indicatorReference"]?.ToString(),
                                    MaxNonlinearity = reader["maxNonlinearity"]?.ToString(),
                                    XiAvg = reader["xiAvg"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["xiAvg"]), 2) : (double?)null,
                                    YiAvg = reader["yiAvg"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["yiAvg"]), 2) : (double?)null,
                                    RealError = reader["realError"]?.ToString(),
                                    Date = reader["date"] != DBNull.Value ? Convert.ToDateTime(reader["date"]) : (DateTime?)null,
                                    Time = reader["time"] != DBNull.Value ? Convert.ToDateTime(reader["time"]) : (DateTime?)null,
                                    BlankNo = reader["blankNo"]?.ToString(),
                                    Tonnes = reader["tonnes"] != DBNull.Value ? Convert.ToDouble(reader["tonnes"]) : (double?)null,
                                    SensorRange = reader["sensorRange"]?.ToString(),
                                    Remark = reader["remark"]?.ToString(),
                                    JobOrder = reader["jobOrder"]?.ToString(),
                                    Customer = reader["customer"]?.ToString(),
                                    VerifiedBy = reader["verifiedBy"]?.ToString(),
                                    TestedBy = reader["testedBy"]?.ToString(),
                                    Division = reader["division"]?.ToString(),
                                    TempDrift = reader["tempDrift"]?.ToString(),
                                    E1 = reader["E1"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E1"]), 2) : (double?)null,
                                    E2 = reader["E2"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E2"]), 2) : (double?)null,
                                    E3 = reader["E3"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E3"]), 2) : (double?)null,
                                    E4 = reader["E4"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E4"]), 2) : (double?)null,
                                    E5 = reader["E5"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E5"]), 2) : (double?)null,
                                    E6 = reader["E6"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E6"]), 2) : (double?)null,
                                    E7 = reader["E7"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E7"]), 2) : (double?)null,
                                    E8 = reader["E8"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E8"]), 2) : (double?)null,
                                    E9 = reader["E9"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E9"]), 2) : (double?)null,
                                    E10 = reader["E10"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E10"]), 2) : (double?)null,
                                    E11 = reader["E11"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["E11"]), 2) : (double?)null,

                                    X1 = reader["X1"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X1"]), 2) : (double?)null,
                                    X2 = reader["X2"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X2"]), 2) : (double?)null,
                                    //X2 = reader["X2"] != DBNull.Value ? Convert.ToDouble(reader["X2"]) : (double?)null,
                                    X3 = reader["X3"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X3"]), 2) : (double?)null,
                                    X4 = reader["X4"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X4"]), 2) : (double?)null,
                                    X5 = reader["X5"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X5"]), 2) : (double?)null,
                                    X6 = reader["X6"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X6"]), 2) : (double?)null,
                                    X7 = reader["X7"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X7"]), 2) : (double?)null,
                                    X8 = reader["X8"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X8"]), 2) : (double?)null,
                                    X9 = reader["X9"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X9"]), 2) : (double?)null,
                                    X10 = reader["X10"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X10"]), 2) : (double?)null,
                                    X11 = reader["X11"] != DBNull.Value ? Math.Round(Convert.ToDouble(reader["X11"]), 2) : (double?)null,

                                    Y1 = reader["Y1"] != DBNull.Value ? Convert.ToDouble(reader["Y1"]) : (double?)null,
                                    Y2 = reader["Y2"] != DBNull.Value ? Convert.ToDouble(reader["Y2"]) : (double?)null,
                                    Y3 = reader["Y3"] != DBNull.Value ? Convert.ToDouble(reader["Y3"]) : (double?)null,
                                    Y4 = reader["Y4"] != DBNull.Value ? Convert.ToDouble(reader["Y4"]) : (double?)null,
                                    Y5 = reader["Y5"] != DBNull.Value ? Convert.ToDouble(reader["Y5"]) : (double?)null,
                                    Y6 = reader["Y6"] != DBNull.Value ? Convert.ToDouble(reader["Y6"]) : (double?)null,
                                    Y7 = reader["Y7"] != DBNull.Value ? Convert.ToDouble(reader["Y7"]) : (double?)null,
                                    Y8 = reader["Y8"] != DBNull.Value ? Convert.ToDouble(reader["Y8"]) : (double?)null,
                                    Y9 = reader["Y9"] != DBNull.Value ? Convert.ToDouble(reader["Y9"]) : (double?)null,
                                    Y10 = reader["Y10"] != DBNull.Value ? Convert.ToDouble(reader["Y10"]) : (double?)null,
                                    Y11 = reader["Y11"] != DBNull.Value ? Convert.ToDouble(reader["Y11"]) : (double?)null
                                };

                                return Json(data); // Return data as JSON
                            }
                        }
                    }
                }

                return Json(null); // No data found
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching data: {ex.Message}");
            }
        }
        [HttpPost]

        public IActionResult Edit(DisynetDataModel model)
        {
            if (model == null)
            {
                return Json("Invalid data submitted.");
            }

            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE disynetdata SET
                    objectType = @objectType,
                    objectName = @objectName,
                    errorDescription = @errorDescription,
                    modelNo = @modelNo,
                    capacity = @capacity,
                    inputResistance = @inputResistance,
                    outputResistance = @outputResistance,
                    excitationVoltage = @excitationVoltage,
                    initialUnbalance = @initialUnbalance,
                    loadingDevice = @loadingDevice,
                    sensitivity = @sensitivity,
                    indicatorReference = @indicatorReference,
                    maxNonlinearity = @maxNonlinearity,
                    xiAvg = @xiAvg,
                    yiAvg = @yiAvg,
                    realError = @realError,
                    date = @date,
                    time = @time,
                    blankNo = @blankNo,
                    tonnes = @tonnes,
                    sensorRange = @sensorRange,
                    remark = @remark,
                    jobOrder = @jobOrder,
                    customer = @customer,
                    verifiedBy = @verifiedBy,
                    testedBy = @testedBy,
                    division = @division,
                    tempDrift = @tempDrift,
                    E1 = @E1,
                    E2 = @E2,
                    E3 = @E3,
                    E4 = @E4,
                    E5 = @E5,
                    E6 = @E6,
                    E7 = @E7,
                    E8 = @E8,
                    E9 = @E9,
                    E10 = @E10,
                    E11 = @E11,
                    X1 = @X1,
                    X2 = @X2,
                    X3 = @X3,
                    X4 = @X4,
                    X5 = @X5,
                    X6 = @X6,
                    X7 = @X7,
                    X8 = @X8,
                    X9 = @X9,
                    X10 = @X10,
                    X11 = @X11,
                    Y1 = @Y1,
                    Y2 = @Y2,
                    Y3 = @Y3,
                    Y4 = @Y4,
                    Y5 = @Y5,
                    Y6 = @Y6,
                    Y7 = @Y7,
                    Y8 = @Y8,
                    Y9 = @Y9,
                    Y10 = @Y10,
                    Y11 = @Y11
                WHERE serialNumber = @serialNumber";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        // Helper method to add parameters
                        void AddParam(string paramName, object value)
                        {
                            command.Parameters.AddWithValue(paramName, value ?? DBNull.Value);
                        }

                        AddParam("@objectType", model.ObjectType);
                        AddParam("@objectName", model.ObjectName);
                        AddParam("@errorDescription", model.ErrorDescription);
                        AddParam("@serialNumber", model.SerialNumber);
                        AddParam("@modelNo", model.ModelNo);
                        AddParam("@capacity", model.Capacity);
                        AddParam("@inputResistance", model.InputResistance);
                        AddParam("@outputResistance", model.OutputResistance);
                        AddParam("@excitationVoltage", model.ExcitationVoltage);
                        AddParam("@initialUnbalance", model.InitialUnbalance);
                        AddParam("@loadingDevice", model.LoadingDevice);
                        AddParam("@sensitivity", model.Sensitivity);
                        AddParam("@indicatorReference", model.IndicatorReference);
                        AddParam("@maxNonlinearity", model.MaxNonlinearity);
                        AddParam("@xiAvg", model.XiAvg);
                        AddParam("@yiAvg", model.YiAvg);
                        AddParam("@realError", model.RealError);
                        AddParam("@date", model.Date);
                        AddParam("@time", model.Time);
                        AddParam("@blankNo", model.BlankNo);
                        AddParam("@tonnes", model.Tonnes);
                        AddParam("@sensorRange", model.SensorRange);
                        AddParam("@remark", model.Remark);
                        AddParam("@jobOrder", model.JobOrder);
                        AddParam("@customer", model.Customer);
                        AddParam("@verifiedBy", model.VerifiedBy);
                        AddParam("@testedBy", model.TestedBy);
                        AddParam("@division", model.Division);
                        AddParam("@tempDrift", model.TempDrift);
                        AddParam("@E1", model.E1);
                        AddParam("@E2", model.E2);
                        AddParam("@E3", model.E3);
                        AddParam("@E4", model.E4);
                        AddParam("@E5", model.E5);
                        AddParam("@E6", model.E6);
                        AddParam("@E7", model.E7);
                        AddParam("@E8", model.E8);
                        AddParam("@E9", model.E9);
                        AddParam("@E10", model.E10);
                        AddParam("@E11", model.E11);
                        AddParam("@X1", model.X1);
                        AddParam("@X2", model.X2);
                        AddParam("@X3", model.X3);
                        AddParam("@X4", model.X4);
                        AddParam("@X5", model.X5);
                        AddParam("@X6", model.X6);
                        AddParam("@X7", model.X7);
                        AddParam("@X8", model.X8);
                        AddParam("@X9", model.X9);
                        AddParam("@X10", model.X10);
                        AddParam("@X11", model.X11);
                        AddParam("@Y1", model.Y1);
                        AddParam("@Y2", model.Y2);
                        AddParam("@Y3", model.Y3);
                        AddParam("@Y4", model.Y4);
                        AddParam("@Y5", model.Y5);
                        AddParam("@Y6", model.Y6);
                        AddParam("@Y7", model.Y7);
                        AddParam("@Y8", model.Y8);
                        AddParam("@Y9", model.Y9);
                        AddParam("@Y10", model.Y10);
                        AddParam("@Y11", model.Y11);

                        command.ExecuteNonQuery();
                    }
                }
                return Json("Index");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
        
    }
}
