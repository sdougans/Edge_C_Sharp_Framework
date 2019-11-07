cd C:/Users/sdougans/source/repos/HelloWorld/HelloWorld
START /B allure generate "/Reports" -c -o "/allure_results"
timeout 2
START /B allure open "/allure_results"