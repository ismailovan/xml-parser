using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parser.Migrations
{
    /// <inheritdoc />
    public partial class AddColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "MetData",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "dataSource_title",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dd_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dd_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ddavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ddavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ddmax_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ddmax_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "diffSunRad_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "diffSunRad_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "diffSunRadavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "diffSunRadavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "domain_altitude",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "domain_lat",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "domain_lon",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ff_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ff_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ffavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ffavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ffmax_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ffmax_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gSunRad_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gSunRad_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gSunRadavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gSunRadavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hhs_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "hhs_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "msl_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "msl_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mslavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "mslavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nn_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ns_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ns_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "p_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "p_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rh",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rh_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rh_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rh_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rhavg",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rhavg_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rhavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rhavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rr_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rr_val",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rr_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rr_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "snow",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "snow_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "snow_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "snow_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_5_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_5_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "t_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg_5_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg_5_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tavg_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "td",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "td_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "td_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "td_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_10_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_10_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_20_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_20_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_30_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_30_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_50_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_50_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_5_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tg_5_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_10_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_10_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_20_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_20_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_30_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_30_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_50_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_50_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_5_cm_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tgavg_5_cm_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tn_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tn_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_12h_acc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_12h_acc_state",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_12h_acc_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_12h_acc_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_1h_acc_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_1h_acc_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_24h_acc_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tp_24h_acc_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsUpdated",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsUpdated_UTC",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsUpdated_day",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsValid_issued",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsValid_issued_RFC822",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsValid_issued_UTC",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tsValid_issued_day",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tw_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tw_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tx_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tx_var_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "valid",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "validEnd",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "validStart",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "valid_UTC",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "valid_day",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vis_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vis_unit",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "wwsyn_var_desc",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dataSource_title",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "dd_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "dd_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ddavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ddavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ddmax_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ddmax_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "diffSunRad_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "diffSunRad_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "diffSunRadavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "diffSunRadavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "domain_altitude",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "domain_lat",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "domain_lon",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ff_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ff_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ffavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ffavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ffmax_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ffmax_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "gSunRad_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "gSunRad_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "gSunRadavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "gSunRadavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "hhs_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "hhs_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "msl_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "msl_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "mslavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "mslavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "nn_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ns_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "ns_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "p_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "p_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "pavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "pavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rh",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rh_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rh_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rh_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rhavg",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rhavg_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rhavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rhavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rr_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rr_val",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rr_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "rr_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "snow",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "snow_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "snow_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "snow_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t_5_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t_5_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "t_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg_5_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg_5_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tavg_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "td",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "td_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "td_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "td_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_10_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_10_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_20_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_20_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_30_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_30_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_50_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_50_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_5_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tg_5_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_10_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_10_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_20_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_20_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_30_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_30_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_50_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_50_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_5_cm_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tgavg_5_cm_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tn_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tn_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_12h_acc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_12h_acc_state",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_12h_acc_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_12h_acc_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_1h_acc_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_1h_acc_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_24h_acc_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tp_24h_acc_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsUpdated",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsUpdated_UTC",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsUpdated_day",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsValid_issued",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsValid_issued_RFC822",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsValid_issued_UTC",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tsValid_issued_day",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tw_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tw_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tx_var_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "tx_var_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "valid",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "validEnd",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "validStart",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "valid_UTC",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "valid_day",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "vis_desc",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "vis_unit",
                table: "MetData");

            migrationBuilder.DropColumn(
                name: "wwsyn_var_desc",
                table: "MetData");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "MetData",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
