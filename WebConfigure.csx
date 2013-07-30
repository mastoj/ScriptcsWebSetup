#load "ConfigurationClasses.csx"

var json = @"{
		SiteName: ""Test2"",
		Port: 9999,
		FilePath: ""c:\\tmp"",
		AppPool: {
			AppPoolName: ""SiteAppPool""
		},		
		Applications: [
			{
				ApplicationName: ""app1"",
				FilePath: ""c:\\tmp"",
				AppPool: {
					AppPoolName: ""app1AppPool"",
					IdentityMode: ""SpecificUser"",
					UserName: ""name"",
					Password: ""xxxxxxxxxxxxxxxxx""
				},
				Applications: [
					{
						ApplicationName: ""app2"",
						FilePath: ""c:\\tmp"",
						AppPool: {
							AppPoolName: ""app2AppPool""
						}						
					}
				]
			}
		],
		Bindings: [
			{
				Ip: ""*"",
				Port: 9991,
				HostHeader: ""yoyo"",
				Protocol: ""http""
			},
			{
				Ip: ""*"",
				Port: 9992,
				HostHeader: ""yoyo"",
				Protocol: ""http""
			}
		]
	}";

IISSetup.SetupFromJson(json);
