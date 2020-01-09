pipeline {
    agent any
    stages {
        stage('checkout') {
            steps {
                  checkout scm
            }
        }
        stage('build') {
            steps {
                  powershell "& 'C:\\Program Files\\Unity\\Hub\\Editor\\2019.2.17f1\\Editor\\Unity.exe' -quit -batchmode -executeMethod StandaloneWindowsBuild.build -projectPath "${WORKSPACE}""
            }
        }
    }
}