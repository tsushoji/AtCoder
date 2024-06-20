@echo off

rem sln�t�@�C���ɕR�Â������v���W�F�N�g�����X�g
set project_name_1=ABC086A
set project_name_2=ABC081A
set project_name_3=ABC081B
set project_name_4=ABC087B
set project_name_5=ABC083B
set project_name_6=ABC088B
set project_name_7=ABC085B
set project_name_8=ABC085C
set project_name_9=ABC049C
set project_name_10=ABC086C

rem sln�t�@�C���쐬
cd %~dp0
dotnet new sln

setlocal enabledelayedexpansion

rem �v���W�F�N�g�ꎮ�쐬���Asln�t�@�C���ɕR�Â�
set i=1
:FOREACH_MONTH
set it_1=!project_name_%i%!
set it_2=%it_1%Test
if defined it_1 (
  rem �v���W�F�N�g�쐬
  echo project_name_%i%=%it_1%
  mkdir %it_1%
  cd %it_1%
  dotnet new console --language "C#" --framework "netcoreapp3.1"
  rem �쐬�����v���W�F�N�g��sln�t�@�C���ɕR�Â�
  cd ..\
  dotnet sln add %it_1%\%it_1%.csproj
  rem UnitTest�v���W�F�N�g�쐬
  echo project_test_folder_name_%i%=%it_2%
  mkdir %it_2%
  cd %it_2%
  dotnet new mstest --language "C#" --framework "netcoreapp3.1"
  rem �쐬����UnitTest�v���W�F�N�g��sln�t�@�C���ɕR�Â�
  cd ..\
  dotnet sln add %it_2%\%it_2%.csproj
  set /a i+=1
  goto :FOREACH_MONTH
)

rem pause