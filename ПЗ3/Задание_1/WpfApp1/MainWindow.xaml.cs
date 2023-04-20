using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Switch myswitch = new Switch();

        private void shutdown_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                generator_status.Content = myswitch.DisconnectPowerGenerator().ToString();
            }
            catch (PowerGeneratorCommsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        private void core_temperature_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                core_status.Content = myswitch.GetCoreTemperature().ToString();
            }
            catch (CoreTemperatureReadException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        private void insert_rod_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rod_clusters_status.Content = myswitch.InsertRodCluster().ToString();
            }
            catch (RodClusterReleaseException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        private void backup_coolant_system_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                backup_coolant_system_status.Content = myswitch.VerifyBackupCoolantSystem().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        private void primary_coolant_system_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                primary_coolant_system_status.Content = myswitch.VerifyPrimaryCoolantSystem().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        private void radiation_level_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                radiation_status.Content = myswitch.GetRadiationLevel().ToString();
            }
            catch (CoreRadiationLevelReadException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                final_check();
            }
        }

        public void final_check()
        {
            if (generator_status.Content.ToString() == "Success" &&
                core_status.Content.ToString() != "" &&
                rod_clusters_status.Content.ToString() == "Success" &&
                primary_coolant_system_status.Content.ToString() == "OK" &&
                backup_coolant_system_status.Content.ToString() == "OK" &&
                radiation_status.Content.ToString() != ""
                )
            {
                MessageBox.Show("Shutdown complete");
            }
        }
    }

    public enum CoolantSystemStatus { OK, Check, Fail }
    public enum SuccessFailureResult { Success, Fail }
    public class Switch
    {
        private Random rand = new Random();
        /// <summary>
        /// Disconnect from the external power generation systems
        /// </summary>
        /// <returns>Success or Failure</returns>
        ///<exception cref="PowerGeneratorCommsException">Thrown when the physical switch cannot establish a connection to the power generation system</exception>
        public SuccessFailureResult DisconnectPowerGenerator()
        {
            SuccessFailureResult r = SuccessFailureResult.Fail;
            if (rand.Next(1, 10) > 2) r = SuccessFailureResult.Success;
            if (rand.Next(1, 20) > 18) throw new PowerGeneratorCommsException("Network failure accessing Power Generator monitoring system");
            return r;
        }
        /// <summary>
        /// Runs a diagnostic check against the primary coolant system
        /// </summary>
        /// <returns>Coolant System Status (OK, Fail, Check)</returns>
        /// <exception cref="CoolantTemperatureReadException">Thrown when the switch cannot read the temperature from the coolant system</exception>
        /// <exception cref="CoolantPressureReadException">Thrown when the switch cannot read the pressure from the coolant system</exception>
        public CoolantSystemStatus VerifyPrimaryCoolantSystem()
        {
            CoolantSystemStatus c = CoolantSystemStatus.Fail;
            int r = rand.Next(1, 10);
            if (r > 5)
            {
                c = CoolantSystemStatus.OK;
            }
            else if (r > 2)
            {
                c = CoolantSystemStatus.Check;
            }
            if (rand.Next(1, 20) > 18) throw new CoolantTemperatureReadException("Failed to read primary coolant system temperature");
            if (rand.Next(1, 20) > 18) throw new CoolantPressureReadException("Failed to read primary coolant system pressure");
            return c;
        }
        /// <summary>
        /// Runs a diagnostic check against the backup coolant system
        /// </summary>
        /// <returns>Coolant System Status (OK, Fail, Check)</returns>
        /// <exception cref="CoolantTemperatureReadException">Thrown when the switch cannot read the temperature from the coolant system</exception>
        /// <exception cref="CoolantPressureReadException">Thrown when the switch cannot read the pressure from the coolant system</exception>
        public CoolantSystemStatus VerifyBackupCoolantSystem()
        {
            CoolantSystemStatus c = CoolantSystemStatus.Fail;
            int r = rand.Next(1, 10);
            if (r > 5)
            {
                c = CoolantSystemStatus.OK;
            }
            else if (r > 2)
            {
                c = CoolantSystemStatus.Check;
            }
            if (rand.Next(1, 20) > 19) throw new CoolantTemperatureReadException("Failed to read backup coolant system temperature");
            if (rand.Next(1, 20) > 19) throw new CoolantPressureReadException("Failed to read backup coolant system pressure");
            return c;
        }

        /// <summary>
        /// Reads the temperature from the reactor core
        /// </summary>
        /// <returns>Temperature</returns>
        /// <exception cref="CoreTemperatureReadException">Thrown when the switch cannot access the temperature data</exception>
        public double GetCoreTemperature()
        {
            if (rand.Next(1, 20) > 18) throw new CoreTemperatureReadException("Failed to read core reactor system temperature");
            return rand.NextDouble() * 1000;
        }

        /// <summary>
        /// Instructs the reactor to insert the control rods to shut the reactor down
        /// </summary>
        /// <returns>Success or failure</returns>
        /// <exception cref="RodClusterReleaseException">Thrown if the switch device cannot read the rod position</exception>
        public SuccessFailureResult InsertRodCluster()
        {
            SuccessFailureResult r = SuccessFailureResult.Fail;
            if (rand.Next(1, 100) > 5) r = SuccessFailureResult.Success;
            if (rand.Next(1, 10) > 8) throw new RodClusterReleaseException("Sensor failure, cannot verify rod release");
            return r;
        }

        /// <summary>
        /// Reads the radiation level from the reactor core
        /// </summary>
        /// <returns>Temperature</returns>
        /// <exception cref="CoreRadiationLevelReadException">Thrown when the switch cannot access the radiation level data</exception>
        public double GetRadiationLevel()
        {
            if (rand.Next(1, 20) > 18) throw new CoreRadiationLevelReadException("Failed to read core reactor system radiation levels");
            return rand.NextDouble() * 500;
        }

        /// <summary>
        /// Sends a broadcast message to PA system notofying shutdown complete
        /// </summary>
        /// <exception cref="SignallingException">Thrown if the switch cannot connect to the PA system over the network</exception>
        public void SignalShutdownComplete()
        {
            if (rand.Next(1, 20) > 18) throw new SignallingException("Network failure connecting to broadcast systems");
        }
    }
    public class PowerGeneratorCommsException : Exception
    {
        public PowerGeneratorCommsException(string message) : base(message) { }
    }
    public class CoolantSystemException : Exception
    {
        public CoolantSystemException(string message) : base(message) { }
    }
    public class CoolantTemperatureReadException : CoolantSystemException
    {
        public CoolantTemperatureReadException(string message) : base(message) { }
    }
    public class CoolantPressureReadException : CoolantSystemException
    {
        public CoolantPressureReadException(string message) : base(message) { }
    }
    public class CoreTemperatureReadException : Exception
    {
        public CoreTemperatureReadException(string message) : base(message) { }
    }
    public class CoreRadiationLevelReadException : Exception
    {
        public CoreRadiationLevelReadException(string message) : base(message) { }
    }
    public class RodClusterReleaseException : Exception
    {
        public RodClusterReleaseException(string message) : base(message) { }
    }
    public class SignallingException : Exception
    {
        public SignallingException(string message) : base(message) { }
    }
}
