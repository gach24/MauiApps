﻿using ProsperDaily.MVVM.Models;
using ProsperDaily.MVVM.Views;
using ProsperDaily.Repositories;

namespace ProsperDaily
{
    public partial class App : Application
    {

        public static BaseRepository<Transaction> TransactionsRepo { get; private set; }

        public App(BaseRepository<Transaction> transactionRepo)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpHaVddX2NLfUN1T2dZdVpxZDU7a15RRnVfQF1lSHtXdkFhW3xXcw==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRBQmtWfFN0RnNadVpwflFHcDwsT3RfQF5jS35Vd0BnWXtccnFTRQ==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxBYVF2R2BJfFR0dF9CYUwxOX1dQl9gSXxTcERmXX9acnZSRmM=;MTA3NTM2OUAzMjMwMmUzNDJlMzBYQXJzcStPSEFmTWQ0VituRUNkendOUlp0eGIya2J6MzJVbFFpckJ0ZU5vPQ==;MTA3NTM3MEAzMjMwMmUzNDJlMzBZT21rOExTNm14VUpjSVNJWmp3a2hheDdJaFZqcnlMd2NzdHRaL0ZSRWZFPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmBWdkx0RWFab116cFVMZF1BJAtUQF1hSn5RdkNiXHtedHZWRGlf;MTA3NTM3MkAzMjMwMmUzNDJlMzBOTXdoRmtJTm80bVVPMmRZT1hjSngrb3FGR1cxa29NZkFGVUpkYTU1bnVFPQ==;MTA3NTM3M0AzMjMwMmUzNDJlMzBMdjRqckFML3lYQ2VBVklMUEs1dDFTWjA1RzkxSmdKK3pCaU53NXFhbzlFPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXnxBYVF2R2BJfFR0dF9CYUwxOX1dQl9gSXxTcERmXX9acnddT2k=;MTA3NTM3NUAzMjMwMmUzNDJlMzBFdWpyOENvUmNFcDRMTVR5VjN1VHFyT1A3dFFadVgrSmRrcjlvRGtJdkdrPQ==;MTA3NTM3NkAzMjMwMmUzNDJlMzBUTGcxRGpSc01kOVNXaGgvNFVTcXdtUzJCWS9kVXFub1d6dXIxTm44L2dvPQ==;MTA3NTM3N0AzMjMwMmUzNDJlMzBOTXdoRmtJTm80bVVPMmRZT1hjSngrb3FGR1cxa29NZkFGVUpkYTU1bnVFPQ==");

            TransactionsRepo = transactionRepo;

            InitializeComponent();

            // MainPage = new NavigationPage(new DashboardView());
            MainPage = new AppContainer();
        }
    }
}