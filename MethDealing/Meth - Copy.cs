//Using this source code?
//Adding new features?
//Have feedback on my coding methods?

//Shoot me a message on GTA5-mods at https://www.gta5-mods.com/users/FelixTheBlackCat

//Original file - https://www.gta5-mods.com/scripts/meth-dealing-cooking-breaking-bad

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using GTA;
using GTA.Math;
using GTA.Native;
using LemonUI;
using System.Linq;
using System.Reflection;
using System.Drawing;
#pragma warning disable IDE1006

namespace RP
{
    public class Meth : Script
    {
        public static Model RequestModel(string Name)
        {

            var model = new Model(Name);
            model.Request(250);

            // Check the model is valid
            if (model.IsInCdImage && model.IsValid)
            {
                // Ensure the model is loaded before we try to create it in the world
                while (!model.IsLoaded) Script.Wait(50);
                return model;




            }

            // Mark the model as no longer needed to remove it from memory.

            model.MarkAsNoLongerNeeded();
            return model;
        }
        public static Model RequestModel(int Name)
        {

            var model = new Model(Name);
            model.Request(250);

            // Check the model is valid
            if (model.IsInCdImage && model.IsValid)
            {
                // Ensure the model is loaded before we try to create it in the world
                while (!model.IsLoaded) Script.Wait(50);
                return model;




            }

            // Mark the model as no longer needed to remove it from memory.

            model.MarkAsNoLongerNeeded();
            return model;
        }
        public static Model RequestModel(PedHash Name)
        {

            var model = new Model(Name);
            model.Request(250);

            // Check the model is valid
            if (model.IsInCdImage && model.IsValid)
            {
                // Ensure the model is loaded before we try to create it in the world
                while (!model.IsLoaded) Script.Wait(50);
                return model;




            }

            // Mark the model as no longer needed to remove it from memory.

            model.MarkAsNoLongerNeeded();
            return model;
        }
        public static Model RequestModel(VehicleHash Name)
        {

            var model = new Model(Name);
            model.Request(250);

            // Check the model is valid
            if (model.IsInCdImage && model.IsValid)
            {
                // Ensure the model is loaded before we try to create it in the world
                while (!model.IsLoaded) Script.Wait(50);
                return model;




            }

            // Mark the model as no longer needed to remove it from memory.

            model.MarkAsNoLongerNeeded();
            return model;
        }
        public static string SelectedButtonIndex;
        public class ButtonData
        {
            public int ButtonID { get; set; }
            public string DisplayName { get; set; }
            public string KeyboardKey { get; set; }
            public string ControllerKey { get; set; }

            public ButtonData()
            {

            }
            public ButtonData(int bid, string dn, string kk, string ck)
            {
                ButtonID = bid;
                DisplayName = dn;
                KeyboardKey = kk;
                ControllerKey = ck;
            }
        }
        public static string ReturnButtonString(int ID)
        {
            SelectedButtonIndex = "Error Invald Key ID";
            if (ID < 358)
            {
                foreach (ButtonData D in ButtonIndex)
                {
                    if (D.ButtonID == ID)
                    {
                        SelectedButtonIndex = D.DisplayName;
                        string Input = SelectedButtonIndex;
                        //GTA.UI.Screen.ShowSubtitle("SelectedButtonIndex " + SelectedButtonIndex);
                        SelectedButtonIndex = @"~" + Input + @"~";
                    }
                }


            }
            else
            {
                SelectedButtonIndex = "Error Invald Key ID :" + ID;
            }
            return SelectedButtonIndex;
        }
        public int ReturnButtonID(int ID)
        {
            return ID;
        }
        public static List<ButtonData> ButtonIndex = new List<ButtonData>()
        {
            new ButtonData(0, "INPUT_NEXT_CAMERA","V","BACK"),
            new ButtonData(1, "INPUT_LOOK_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(2, "INPUT_LOOK_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(3, "INPUT_LOOK_UP_ONLY","(NONE)","RIGHT STICK"),
            new ButtonData(4, "INPUT_LOOK_DOWN_ONLY","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(5, "INPUT_LOOK_LEFT_ONLY","(NONE)","RIGHT STICK"),
            new ButtonData(6, "INPUT_LOOK_RIGHT_ONLY","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(7, "INPUT_CINEMATIC_SLOWMO","(NONE)","R3"),
            new ButtonData(8, "INPUT_SCRIPTED_FLY_UD","S","LEFT STICK"),
            new ButtonData(9, "INPUT_SCRIPTED_FLY_LR","D","LEFT STICK"),
            new ButtonData(10, "INPUT_SCRIPTED_FLY_ZUP","PAGEUP","LT"),
            new ButtonData(11, "INPUT_SCRIPTED_FLY_ZDOWN","PAGEDOWN","RT"),
            new ButtonData(12, "INPUT_WEAPON_WHEEL_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(13, "INPUT_WEAPON_WHEEL_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(14, "INPUT_WEAPON_WHEEL_NEXT","SCROLLWHEEL DOWN","DPAD RIGHT"),
            new ButtonData(15, "INPUT_WEAPON_WHEEL_PREV","SCROLLWHEEL UP","DPAD LEFT"),
            new ButtonData(16, "INPUT_SELECT_NEXT_WEAPON","SCROLLWHEEL","DOWN (NONE)"),
            new ButtonData(17, "INPUT_SELECT_PREV_WEAPON","SCROLLWHEEL","UP (NONE)"),
            new ButtonData(18, "INPUT_SKIP_CUTSCENE","ENTER / LEFT MOUSE BUTTON/SPACEBAR","A"),
            new ButtonData(19, "INPUT_CHARACTER_WHEEL","LEFT ALT","DPAD DOWN"),
            new ButtonData(20, "INPUT_MULTIPLAYER_INFO","Z","DPAD DOWN"),
            new ButtonData(21, "INPUT_SPRINT","LEFT","SHIFT A"),
            new ButtonData(22, "INPUT_JUMP","SPACEBAR","X"),
            new ButtonData(23, "INPUT_ENTER","F","Y"),
            new ButtonData(24, "INPUT_ATTACK","LEFT MOUSE","BUTTON RT"),
            new ButtonData(25, "INPUT_AIM","RIGHT MOUSE","BUTTON LT"),
            new ButtonData(26, "INPUT_LOOK_BEHIND","C","R3"),
            new ButtonData(27, "INPUT_PHONE","ARROW UP / SCROLLWHEEL BUTTON(PRESS)DPAD","UP"),
            new ButtonData(28, "INPUT_SPECIAL_ABILITY","(NONE)","L3"),
            new ButtonData(29, "INPUT_SPECIAL_ABILITY_SECONDARY","B","R3"),
            new ButtonData(30, "INPUT_MOVE_LR","D","LEFT STICK"),
            new ButtonData(31, "INPUT_MOVE_UD","S","LEFT STICK"),
            new ButtonData(32, "INPUT_MOVE_UP_ONLY","W","LEFT STICK"),
            new ButtonData(33, "INPUT_MOVE_DOWN_ONLY","S","LEFT STICK"),
            new ButtonData(34, "INPUT_MOVE_LEFT_ONLY","A","LEFT STICK"),
            new ButtonData(35, "INPUT_MOVE_RIGHT_ONLY","D","LEFT STICK"),
            new ButtonData(36, "INPUT_DUCK","LEFT","CTRL L3"),
            new ButtonData(37, "INPUT_SELECT_WEAPON","TAB","LB"),
            new ButtonData(38, "INPUT_PICKUP","E","LB"),
            new ButtonData(39, "INPUT_SNIPER_ZOOM","[LEFT","STICK"),
            new ButtonData(40, "INPUT_SNIPER_ZOOM_IN_ONLY]","LEFT","STICK"),
            new ButtonData(41, "INPUT_SNIPER_ZOOM_OUT_ONLY","[LEFT","STICK"),
            new ButtonData(42, "INPUT_SNIPER_ZOOM_IN_SECONDARY]","DPAD","UP"),
            new ButtonData(43, "INPUT_SNIPER_ZOOM_OUT_SECONDARY","[DPAD","DOWN"),
            new ButtonData(44, "INPUT_COVER","Q","RB"),
            new ButtonData(45, "INPUT_RELOAD","R","B"),
            new ButtonData(46, "INPUT_TALK","E","DPAD RIGHT"),
            new ButtonData(47, "INPUT_DETONATE","G","DPAD LEFT"),
            new ButtonData(48, "INPUT_HUD_SPECIAL","Z","DPAD DOWN"),
            new ButtonData(49, "INPUT_ARREST","F","Y"),
            new ButtonData(50, "INPUT_ACCURATE_AIM","SCROLLWHEEL","DOWN R3"),
            new ButtonData(51, "INPUT_CONTEXT","E","DPAD RIGHT"),
            new ButtonData(52, "INPUT_CONTEXT_SECONDARY","Q","DPAD LEFT"),
            new ButtonData(53, "INPUT_WEAPON_SPECIAL","(NONE)","Y"),
            new ButtonData(54, "INPUT_WEAPON_SPECIAL_TWO","E","DPAD RIGHT"),
            new ButtonData(55, "INPUT_DIVE","SPACEBAR","RB"),
            new ButtonData(56, "INPUT_DROP_WEAPON","F9","Y"),
            new ButtonData(57, "INPUT_DROP_AMMO","F10","B"),
            new ButtonData(58, "INPUT_THROW_GRENADE","G","DPAD LEFT"),
            new ButtonData(59, "INPUT_VEH_MOVE_LR","D","LEFT STICK"),
            new ButtonData(60, "INPUT_VEH_MOVE_UD","LEFT CTRL","LEFT STICK"),
            new ButtonData(61, "INPUT_VEH_MOVE_UP_ONLY","LEFT SHIFT","LEFT STICK"),
            new ButtonData(62, "INPUT_VEH_MOVE_DOWN_ONLY","LEFT CTRL","LEFT STICK"),
            new ButtonData(63, "INPUT_VEH_MOVE_LEFT_ONLY","A","LEFT STICK"),
            new ButtonData(64, "INPUT_VEH_MOVE_RIGHT_ONLY","D","LEFT STICK"),
            new ButtonData(65, "INPUT_VEH_SPECIAL","(NONE)","(NONE)"),
            new ButtonData(66, "INPUT_VEH_GUN_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(67, "INPUT_VEH_GUN_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(68, "INPUT_VEH_AIM","RIGHT MOUSE","BUTTON LB"),
            new ButtonData(69, "INPUT_VEH_ATTACK","LEFT MOUSE","BUTTON RB"),
            new ButtonData(70, "INPUT_VEH_ATTACK2","RIGHT MOUSE","BUTTON A"),
            new ButtonData(71, "INPUT_VEH_ACCELERATE","W","RT"),
            new ButtonData(72, "INPUT_VEH_BRAKE","S","LT"),
            new ButtonData(73, "INPUT_VEH_DUCK","X","A"),
            new ButtonData(74, "INPUT_VEH_HEADLIGHT","H","DPAD RIGHT"),
            new ButtonData(75, "INPUT_VEH_EXIT","F","Y"),
            new ButtonData(76, "INPUT_VEH_HANDBRAKE","SPACEBAR","RB"),
            new ButtonData(77, "INPUT_VEH_HOTWIRE_LEFT","W","LT"),
            new ButtonData(78, "INPUT_VEH_HOTWIRE_RIGHT","S","RT"),
            new ButtonData(79, "INPUT_VEH_LOOK_BEHIND","C","R3"),
            new ButtonData(80, "INPUT_VEH_CIN_CAM","R","B"),
            new ButtonData(81, "INPUT_VEH_NEXT_RADIO",".","(NONE)"),
            new ButtonData(82, "INPUT_VEH_PREV_RADIO",",","(NONE)"),
            new ButtonData(83, "INPUT_VEH_NEXT_RADIO_TRACK","=","(NONE)"),
            new ButtonData(84, "INPUT_VEH_PREV_RADIO_TRACK","-","(NONE)"),
            new ButtonData(85, "INPUT_VEH_RADIO_WHEEL","Q","DPAD LEFT"),
            new ButtonData(86, "INPUT_VEH_HORN","E","L3"),
            new ButtonData(87, "INPUT_VEH_FLY_THROTTLE_UP","W","RT"),
            new ButtonData(88, "INPUT_VEH_FLY_THROTTLE_DOWN","S","LT"),
            new ButtonData(89, "INPUT_VEH_FLY_YAW_LEFT","A","LB"),
            new ButtonData(90, "INPUT_VEH_FLY_YAW_RIGHT","D","RB"),
            new ButtonData(91, "INPUT_VEH_PASSENGER_AIM","RIGHT MOUSE","BUTTON LT"),
            new ButtonData(92, "INPUT_VEH_PASSENGER_ATTACK","LEFT MOUSE","BUTTON RT"),
            new ButtonData(93, "INPUT_VEH_SPECIAL_ABILITY_FRANKLIN","(NONE)","R3"),
            new ButtonData(94, "INPUT_VEH_STUNT_UD","(NONE)","(NONE)"),
            new ButtonData(95, "INPUT_VEH_CINEMATIC_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(96, "INPUT_VEH_CINEMATIC_UP_ONLY","NUMPAD- /","SCROLLWHEEL UP(NONE)"),
            new ButtonData(97, "INPUT_VEH_CINEMATIC_DOWN_ONLY","NUMPAD+ /","SCROLLWHEEL DOWN(NONE)"),
            new ButtonData(98, "INPUT_VEH_CINEMATIC_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(99, "INPUT_VEH_SELECT_NEXT_WEAPON","SCROLLWHEEL","UP X"),
            new ButtonData(100, "INPUT_VEH_SELECT_PREV_WEAPON","[","(NONE)"),
            new ButtonData(101, "INPUT_VEH_ROOF","H","DPAD RIGHT"),
            new ButtonData(102, "INPUT_VEH_JUMP","SPACEBAR","RB"),
            new ButtonData(103, "INPUT_VEH_GRAPPLING_HOOK","E","DPAD RIGHT"),
            new ButtonData(104, "INPUT_VEH_SHUFFLE","H","DPAD RIGHT"),
            new ButtonData(105, "INPUT_VEH_DROP_PROJECTILE","X","A"),
            new ButtonData(106, "INPUT_VEH_MOUSE_CONTROL_OVERRIDE","LEFT","MOUSE BUTTON(NONE)"),
            new ButtonData(107, "INPUT_VEH_FLY_ROLL_LR","NUMPAD 6","LEFT STICK"),
            new ButtonData(108, "INPUT_VEH_FLY_ROLL_LEFT_ONLY","NUMPAD 4","LEFT STICK"),
            new ButtonData(109, "INPUT_VEH_FLY_ROLL_RIGHT_ONLY","NUMPAD 6","LEFT STICK"),
            new ButtonData(110, "INPUT_VEH_FLY_PITCH_UD","NUMPAD 5","LEFT STICK"),
            new ButtonData(111, "INPUT_VEH_FLY_PITCH_UP_ONLY","NUMPAD 8","LEFT STICK"),
            new ButtonData(112, "INPUT_VEH_FLY_PITCH_DOWN_ONLY","NUMPAD 5","LEFT STICK"),
            new ButtonData(113, "INPUT_VEH_FLY_UNDERCARRIAGE","G","L3"),
            new ButtonData(114, "INPUT_VEH_FLY_ATTACK","RIGHT MOUSE","BUTTON A"),
            new ButtonData(115, "INPUT_VEH_FLY_SELECT_NEXT_WEAPON","SCROLLWHEEL UP","DPAD LEFT"),
            new ButtonData(116, "INPUT_VEH_FLY_SELECT_PREV_WEAPON","[","(NONE)"),
            new ButtonData(117, "INPUT_VEH_FLY_SELECT_TARGET_LEFT","NUMPAD","7 LB"),
            new ButtonData(118, "INPUT_VEH_FLY_SELECT_TARGET_RIGHT","NUMPAD","9 RB"),
            new ButtonData(119, "INPUT_VEH_FLY_VERTICAL_FLIGHT_MODE","E","DPAD RIGHT"),
            new ButtonData(120, "INPUT_VEH_FLY_DUCK","X","A"),
            new ButtonData(121, "INPUT_VEH_FLY_ATTACK_CAMERA","INSERT","R3"),
            new ButtonData(122, "INPUT_VEH_FLY_MOUSE_CONTROL_OVERRIDE","LEFT","MOUSE BUTTON(NONE)"),
            new ButtonData(123, "INPUT_VEH_SUB_TURN_LR","NUMPAD 6","LEFT STICK"),
            new ButtonData(124, "INPUT_VEH_SUB_TURN_LEFT_ONLY","NUMPAD 4","LEFT STICK"),
            new ButtonData(125, "INPUT_VEH_SUB_TURN_RIGHT_ONLY","NUMPAD 6","LEFT STICK"),
            new ButtonData(126, "INPUT_VEH_SUB_PITCH_UD","NUMPAD 5","LEFT STICK"),
            new ButtonData(127, "INPUT_VEH_SUB_PITCH_UP_ONLY","NUMPAD 8","LEFT STICK"),
            new ButtonData(128, "INPUT_VEH_SUB_PITCH_DOWN_ONLY","NUMPAD 5","LEFT STICK"),
            new ButtonData(129, "INPUT_VEH_SUB_THROTTLE_UP","W","RT"),
            new ButtonData(130, "INPUT_VEH_SUB_THROTTLE_DOWN","S","LT"),
            new ButtonData(131, "INPUT_VEH_SUB_ASCEND","LEFT","SHIFT X"),
            new ButtonData(132, "INPUT_VEH_SUB_DESCEND","LEFT","CTRL A"),
            new ButtonData(133, "INPUT_VEH_SUB_TURN_HARD_LEFT","A","LB"),
            new ButtonData(134, "INPUT_VEH_SUB_TURN_HARD_RIGHT","D","RB"),
            new ButtonData(135, "INPUT_VEH_SUB_MOUSE_CONTROL_OVERRIDE","LEFT","MOUSE BUTTON(NONE)"),
            new ButtonData(136, "INPUT_VEH_PUSHBIKE_PEDAL","W","A"),
            new ButtonData(137, "INPUT_VEH_PUSHBIKE_SPRINT","CAPSLOCK","A"),
            new ButtonData(138, "INPUT_VEH_PUSHBIKE_FRONT_BRAKE","Q","LT"),
            new ButtonData(139, "INPUT_VEH_PUSHBIKE_REAR_BRAKE","S","RT"),
            new ButtonData(140, "INPUT_MELEE_ATTACK_LIGHT","R","B"),
            new ButtonData(141, "INPUT_MELEE_ATTACK_HEAVY","Q","A"),
            new ButtonData(142, "INPUT_MELEE_ATTACK_ALTERNATE","LEFT MOUSE","BUTTON RT"),
            new ButtonData(143, "INPUT_MELEE_BLOCK","SPACEBAR","X"),
            new ButtonData(144, "INPUT_PARACHUTE_DEPLOY","F / LEFT MOUSE BUTTON","Y"),
            new ButtonData(145, "INPUT_PARACHUTE_DETACH","F","Y"),
            new ButtonData(146, "INPUT_PARACHUTE_TURN_LR","D","LEFT STICK"),
            new ButtonData(147, "INPUT_PARACHUTE_TURN_LEFT_ONLY","A","LEFT STICK"),
            new ButtonData(148, "INPUT_PARACHUTE_TURN_RIGHT_ONLY","D","LEFT STICK"),
            new ButtonData(149, "INPUT_PARACHUTE_PITCH_UD","S","LEFT STICK"),
            new ButtonData(150, "INPUT_PARACHUTE_PITCH_UP_ONLY","W","LEFT STICK"),
            new ButtonData(151, "INPUT_PARACHUTE_PITCH_DOWN_ONLY","S","LEFT STICK"),
            new ButtonData(152, "INPUT_PARACHUTE_BRAKE_LEFT","Q","LB"),
            new ButtonData(153, "INPUT_PARACHUTE_BRAKE_RIGHT","E","RB"),
            new ButtonData(154, "INPUT_PARACHUTE_SMOKE","X","A"),
            new ButtonData(155, "INPUT_PARACHUTE_PRECISION_LANDING","LEFT","SHIFT(NONE)"),
            new ButtonData(156, "INPUT_MAP","(NONE)","(NONE)"),
            new ButtonData(157, "INPUT_SELECT_WEAPON_UNARMED","1","(NONE)"),
            new ButtonData(158, "INPUT_SELECT_WEAPON_MELEE","2","(NONE)"),
            new ButtonData(159, "INPUT_SELECT_WEAPON_HANDGUN","6","(NONE)"),
            new ButtonData(160, "INPUT_SELECT_WEAPON_SHOTGUN","3","(NONE)"),
            new ButtonData(161, "INPUT_SELECT_WEAPON_SMG","7","(NONE)"),
            new ButtonData(162, "INPUT_SELECT_WEAPON_AUTO_RIFLE","8","(NONE)"),
            new ButtonData(163, "INPUT_SELECT_WEAPON_SNIPER","9","(NONE)"),
            new ButtonData(164, "INPUT_SELECT_WEAPON_HEAVY","4","(NONE)"),
            new ButtonData(165, "INPUT_SELECT_WEAPON_SPECIAL","5","(NONE)"),
            new ButtonData(166, "INPUT_SELECT_CHARACTER_MICHAEL","F5","(NONE)"),
            new ButtonData(167, "INPUT_SELECT_CHARACTER_FRANKLIN","F6","(NONE)"),
            new ButtonData(168, "INPUT_SELECT_CHARACTER_TREVOR","F7","(NONE)"),
            new ButtonData(169, "INPUT_SELECT_CHARACTER_MULTIPLAYER","F8(CONSOLE)","(NONE)"),
            new ButtonData(170, "INPUT_SAVE_REPLAY_CLIP","F3","B"),
            new ButtonData(171, "INPUT_SPECIAL_ABILITY_PC","CAPSLOCK","(NONE)"),
            new ButtonData(172, "INPUT_CELLPHONE_UP","ARROW UP","DPAD UP"),
            new ButtonData(173, "INPUT_CELLPHONE_DOWN","ARROW DOWN","DPAD DOWN"),
            new ButtonData(174, "INPUT_CELLPHONE_LEFT","ARROW LEFT","DPAD LEFT"),
            new ButtonData(175, "INPUT_CELLPHONE_RIGHT","ARROW RIGHT","DPAD RIGHT"),
            new ButtonData(176, "INPUT_CELLPHONE_SELECT","ENTER / LEFT MOUSE BUTTON","A"),
            new ButtonData(177, "INPUT_CELLPHONE_CANCEL","BACKSPACE / ESC / RIGHTMOUSEBUTTON","B"),
            new ButtonData(178, "INPUT_CELLPHONE_OPTION","DELETE","Y"),
            new ButtonData(179, "INPUT_CELLPHONE_EXTRA_OPTION","SPACEBAR","X"),
            new ButtonData(180, "INPUT_CELLPHONE_SCROLL_FORWARD","SCROLLWHEEL","DOWN(NONE)"),
            new ButtonData(181, "INPUT_CELLPHONE_SCROLL_BACKWARD","SCROLLWHEEL","UP(NONE)"),
            new ButtonData(182, "INPUT_CELLPHONE_CAMERA_FOCUS_LOCK","L","RT"),
            new ButtonData(183, "INPUT_CELLPHONE_CAMERA_GRID","G","RB"),
            new ButtonData(184, "INPUT_CELLPHONE_CAMERA_SELFIE","E","R3"),
            new ButtonData(185, "INPUT_CELLPHONE_CAMERA_DOF","F","LB"),
            new ButtonData(186, "INPUT_CELLPHONE_CAMERA_EXPRESSION","X","L3"),
            new ButtonData(187, "INPUT_FRONTEND_DOWN","ARROW DOWN","DPAD DOWN"),
            new ButtonData(188, "INPUT_FRONTEND_UP","ARROW UP","DPAD UP"),
            new ButtonData(189, "INPUT_FRONTEND_LEFT","ARROW LEFT","DPAD LEFT"),
            new ButtonData(190, "INPUT_FRONTEND_RIGHT","ARROW RIGHT","DPAD RIGHT"),
            new ButtonData(191, "INPUT_FRONTEND_RDOWN","ENTER","A"),
            new ButtonData(192, "INPUT_FRONTEND_RUP","TAB","Y"),
            new ButtonData(193, "INPUT_FRONTEND_RLEFT","(NONE)","X"),
            new ButtonData(194, "INPUT_FRONTEND_RRIGHT","BACKSPACE","B"),
            new ButtonData(195, "INPUT_FRONTEND_AXIS_X","D","LEFT STICK"),
            new ButtonData(196, "INPUT_FRONTEND_AXIS_Y","S","LEFT STICK"),
            new ButtonData(197, "INPUT_FRONTEND_RIGHT_AXIS_X]","RIGHT","STICK"),
            new ButtonData(198, "INPUT_FRONTEND_RIGHT_AXIS_Y","SCROLLWHEEL DOWN","RIGHT STICK"),
            new ButtonData(199, "INPUT_FRONTEND_PAUSE","P","START"),
            new ButtonData(200, "INPUT_FRONTEND_PAUSE_ALTERNATE","ESC","(NONE)"),
            new ButtonData(201, "INPUT_FRONTEND_ACCEPT","ENTER / NUMPAD ENTER","A"),
            new ButtonData(202, "INPUT_FRONTEND_CANCEL","BACKSPACE /","ESC B"),
            new ButtonData(203, "INPUT_FRONTEND_X","SPACEBAR","X"),
            new ButtonData(204, "INPUT_FRONTEND_Y","TAB","Y"),
            new ButtonData(205, "INPUT_FRONTEND_LB","Q","LB"),
            new ButtonData(206, "INPUT_FRONTEND_RB","E","RB"),
            new ButtonData(207, "INPUT_FRONTEND_LT","PAGE","DOWN LT"),
            new ButtonData(208, "INPUT_FRONTEND_RT","PAGE","UP RT"),
            new ButtonData(209, "INPUT_FRONTEND_LS","LEFT","SHIFT L3"),
            new ButtonData(210, "INPUT_FRONTEND_RS","LEFT","CONTROL R3"),
            new ButtonData(211, "INPUT_FRONTEND_LEADERBOARD","TAB","RB"),
            new ButtonData(212, "INPUT_FRONTEND_SOCIAL_CLUB","HOME","BACK"),
            new ButtonData(213, "INPUT_FRONTEND_SOCIAL_CLUB_SECONDARY","HOME","RB"),
            new ButtonData(214, "INPUT_FRONTEND_DELETE","DELETE","X"),
            new ButtonData(215, "INPUT_FRONTEND_ENDSCREEN_ACCEPT","ENTER","A"),
            new ButtonData(216, "INPUT_FRONTEND_ENDSCREEN_EXPAND","SPACEBAR","X"),
            new ButtonData(217, "INPUT_FRONTEND_SELECT","CAPSLOCK","BACK"),
            new ButtonData(218, "INPUT_SCRIPT_LEFT_AXIS_X","D","LEFT STICK"),
            new ButtonData(219, "INPUT_SCRIPT_LEFT_AXIS_Y","S","LEFT STICK"),
            new ButtonData(220, "INPUT_SCRIPT_RIGHT_AXIS_X","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(221, "INPUT_SCRIPT_RIGHT_AXIS_Y","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(222, "INPUT_SCRIPT_RUP","RIGHT MOUSE","BUTTON Y"),
            new ButtonData(223, "INPUT_SCRIPT_RDOWN","LEFT MOUSE","BUTTON A"),
            new ButtonData(224, "INPUT_SCRIPT_RLEFT","LEFT","CTRL X"),
            new ButtonData(225, "INPUT_SCRIPT_RRIGHT","RIGHT MOUSE","BUTTON B"),
            new ButtonData(226, "INPUT_SCRIPT_LB","(NONE)","LB"),
            new ButtonData(227, "INPUT_SCRIPT_RB","(NONE)","LT"),
            new ButtonData(228, "INPUT_SCRIPT_LT","(NONE)","LB"),
            new ButtonData(229, "INPUT_SCRIPT_RT","LEFT MOUSE","BUTTON RT"),
            new ButtonData(230, "INPUT_SCRIPT_LS","(NONE)","L3"),
            new ButtonData(231, "INPUT_SCRIPT_RS","(NONE)","R3"),
            new ButtonData(232, "INPUT_SCRIPT_PAD_UP","W","DPAD UP"),
            new ButtonData(233, "INPUT_SCRIPT_PAD_DOWN","S","DPAD DOWN"),
            new ButtonData(234, "INPUT_SCRIPT_PAD_LEFT","A","DPAD LEFT"),
            new ButtonData(235, "INPUT_SCRIPT_PAD_RIGHT","D","DPAD RIGHT"),
            new ButtonData(236, "INPUT_SCRIPT_SELECT","V","BACK"),
            new ButtonData(237, "INPUT_CURSOR_ACCEPT","LEFT MOUSE","BUTTON (NONE)"),
            new ButtonData(238, "INPUT_CURSOR_CANCEL","RIGHT MOUSE","BUTTON (NONE)"),
            new ButtonData(239, "INPUT_CURSOR_X","(NONE)","(NONE)"),
            new ButtonData(240, "INPUT_CURSOR_Y","(NONE)","(NONE)"),
            new ButtonData(241, "INPUT_CURSOR_SCROLL_UP","SCROLLWHEEL","UP (NONE)"),
            new ButtonData(242, "INPUT_CURSOR_SCROLL_DOWN","SCROLLWHEEL","DOWN (NONE)"),
            new ButtonData(243, "INPUT_ENTER_CHEAT_CODE","~ /","` (NONE)"),
            new ButtonData(244, "INPUT_INTERACTION_MENU","M","BACK"),
            new ButtonData(245, "INPUT_MP_TEXT_CHAT_ALL","T","(NONE)"),
            new ButtonData(246, "INPUT_MP_TEXT_CHAT_TEAM","Y","(NONE)"),
            new ButtonData(247, "INPUT_MP_TEXT_CHAT_FRIENDS","(NONE)","(NONE)"),
            new ButtonData(248, "INPUT_MP_TEXT_CHAT_CREW","(NONE)","(NONE)"),
            new ButtonData(249, "INPUT_PUSH_TO_TALK","N","(NONE)"),
            new ButtonData(250, "INPUT_CREATOR_LS","R","L3"),
            new ButtonData(251, "INPUT_CREATOR_RS","F","R3"),
            new ButtonData(252, "INPUT_CREATOR_LT","X","LT"),
            new ButtonData(253, "INPUT_CREATOR_RT","C","RT"),
            new ButtonData(254, "INPUT_CREATOR_MENU_TOGGLE","LEFT","SHIFT (NONE)"),
            new ButtonData(255, "INPUT_CREATOR_ACCEPT","SPACEBAR","A"),
            new ButtonData(256, "INPUT_CREATOR_DELETE","DELETE","X"),
            new ButtonData(257, "INPUT_ATTACK2","LEFT MOUSE","BUTTON RT"),
            new ButtonData(258, "INPUT_RAPPEL_JUMP","(NONE)","A"),
            new ButtonData(259, "INPUT_RAPPEL_LONG_JUMP","(NONE)","X"),
            new ButtonData(260, "INPUT_RAPPEL_SMASH_WINDOW","(NONE)","RT"),
            new ButtonData(261, "INPUT_PREV_WEAPON","SCROLLWHEEL UP","DPAD LEFT"),
            new ButtonData(262, "INPUT_NEXT_WEAPON","SCROLLWHEEL DOWN","DPAD RIGHT"),
            new ButtonData(263, "INPUT_MELEE_ATTACK1","R","B"),
            new ButtonData(264, "INPUT_MELEE_ATTACK2","Q","A"),
            new ButtonData(265, "INPUT_WHISTLE","(NONE)","(NONE)"),
            new ButtonData(266, "INPUT_MOVE_LEFT","D","LEFT STICK"),
            new ButtonData(267, "INPUT_MOVE_RIGHT","D","LEFT STICK"),
            new ButtonData(268, "INPUT_MOVE_UP","S","LEFT STICK"),
            new ButtonData(269, "INPUT_MOVE_DOWN","S","LEFT STICK"),
            new ButtonData(270, "INPUT_LOOK_LEFT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(271, "INPUT_LOOK_RIGHT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(272, "INPUT_LOOK_UP","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(273, "INPUT_LOOK_DOWN","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(274, "INPUT_SNIPER_ZOOM_IN","[RIGHT","STICK"),
            new ButtonData(275, "INPUT_SNIPER_ZOOM_OUT","[RIGHT","STICK"),
            new ButtonData(276, "INPUT_SNIPER_ZOOM_IN_ALTERNATE","[LEFT","STICK"),
            new ButtonData(277, "INPUT_SNIPER_ZOOM_OUT_ALTERNATE","[LEFT","STICK"),
            new ButtonData(278, "INPUT_VEH_MOVE_LEFT","D","LEFT STICK"),
            new ButtonData(279, "INPUT_VEH_MOVE_RIGHT","D","LEFT STICK"),
            new ButtonData(280, "INPUT_VEH_MOVE_UP","LEFT CTRL","LEFT STICK"),
            new ButtonData(281, "INPUT_VEH_MOVE_DOWN","LEFT CTRL","LEFT STICK"),
            new ButtonData(282, "INPUT_VEH_GUN_LEFT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(283, "INPUT_VEH_GUN_RIGHT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(284, "INPUT_VEH_GUN_UP","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(285, "INPUT_VEH_GUN_DOWN","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(286, "INPUT_VEH_LOOK_LEFT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(287, "INPUT_VEH_LOOK_RIGHT","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(288, "INPUT_REPLAY_START_STOP_RECORDING","F1","A"),
            new ButtonData(289, "INPUT_REPLAY_START_STOP_RECORDING_SECONDARY","F2","X"),
            new ButtonData(290, "INPUT_SCALED_LOOK_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(291, "INPUT_SCALED_LOOK_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(292, "INPUT_SCALED_LOOK_UP_ONLY(NONE)","RIGHT","STICK"),
            new ButtonData(293, "INPUT_SCALED_LOOK_DOWN_ONLY(NONE)","RIGHT","STICK"),
            new ButtonData(294, "INPUT_SCALED_LOOK_LEFT_ONLY(NONE)","RIGHT","STICK"),
            new ButtonData(295, "INPUT_SCALED_LOOK_RIGHT_ONLY(NONE)","RIGHT","STICK"),
            new ButtonData(296, "INPUT_REPLAY_MARKER_DELETE","DELETE","X"),
            new ButtonData(297, "INPUT_REPLAY_CLIP_DELETE","DELETE","Y"),
            new ButtonData(298, "INPUT_REPLAY_PAUSE","SPACEBAR","A"),
            new ButtonData(299, "INPUT_REPLAY_REWIND","ARROW","DOWN LB"),
            new ButtonData(300, "INPUT_REPLAY_FFWD","ARROW","UP RB"),
            new ButtonData(301, "INPUT_REPLAY_NEWMARKER","M","A"),
            new ButtonData(302, "INPUT_REPLAY_RECORD","S","(NONE)"),
            new ButtonData(303, "INPUT_REPLAY_SCREENSHOT","U","DPAD UP"),
            new ButtonData(304, "INPUT_REPLAY_HIDEHUD","H","R3"),
            new ButtonData(307, "INPUT_REPLAY_ADVANCE","ARROW RIGHT","DPAD RIGHT"),
            new ButtonData(308, "INPUT_REPLAY_BACK","ARROW LEFT","DPAD LEFT"),
            new ButtonData(309, "INPUT_REPLAY_TOOLS","T","DPAD DOWN"),
            new ButtonData(310, "INPUT_REPLAY_RESTART","R","BACK"),
            new ButtonData(311, "INPUT_REPLAY_SHOWHOTKEY","K","DPAD DOWN"),
            new ButtonData(312, "INPUT_REPLAY_CYCLEMARKERLEFT","[DPAD","LEFT"),
            new ButtonData(313, "INPUT_REPLAY_CYCLEMARKERRIGHT]","DPAD","RIGHT"),
            new ButtonData(314, "INPUT_REPLAY_FOVINCREASE","NUMPAD","+ RB"),
            new ButtonData(315, "INPUT_REPLAY_FOVDECREASE","NUMPAD","- LB"),
            new ButtonData(316, "INPUT_REPLAY_CAMERAUP","PAGE","UP (NONE)"),
            new ButtonData(317, "INPUT_REPLAY_CAMERADOWN","PAGE","DOWN (NONE)"),
            new ButtonData(318, "INPUT_REPLAY_SAVE","F5","START"),
            new ButtonData(319, "INPUT_REPLAY_TOGGLETIME","C","(NONE)"),

            new ButtonData(320, "INPUT_REPLAY_TOGGLETIPS","V","(NONE)"),
            new ButtonData(321, "INPUT_REPLAY_PREVIEW","SPACEBAR","(NONE)"),
            new ButtonData(322, "INPUT_REPLAY_TOGGLE_TIMELINE","ESC","(NONE)"),
            new ButtonData(323, "INPUT_REPLAY_TIMELINE_PICKUP_CLIP","X","(NONE)"),
            new ButtonData(324, "INPUT_REPLAY_TIMELINE_DUPLICATE_CLIP","C","(NONE)"),
            new ButtonData(325, "INPUT_REPLAY_TIMELINE_PLACE_CLIP","V","(NONE)"),
            new ButtonData(326, "INPUT_REPLAY_CTRL","LEFT CTRL","(NONE)"),
            new ButtonData(327, "INPUT_REPLAY_TIMELINE_SAVE","F5","CTRL (NONE)"),

            new ButtonData(328, "INPUT_REPLAY_PREVIEW_AUDIO","SPACEBAR","RT"),
            new ButtonData(329, "INPUT_VEH_DRIVE_LOOK","LEFT MOUSE","BUTTON (NONE)"),
            new ButtonData(330, "INPUT_VEH_DRIVE_LOOK2","RIGHT MOUSE","BUTTON (NONE)"),
            new ButtonData(331, "INPUT_VEH_FLY_ATTACK2","RIGHT MOUSE","BUTTON (NONE)"),
            new ButtonData(332, "INPUT_RADIO_WHEEL_UD","MOUSE DOWN","RIGHT STICK"),
            new ButtonData(333, "INPUT_RADIO_WHEEL_LR","MOUSE RIGHT","RIGHT STICK"),
            new ButtonData(334, "INPUT_VEH_SLOWMO_UD","SCROLLWHEEL DOWN","LEFT STICK"),
            new ButtonData(335, "INPUT_VEH_SLOWMO_UP_ONLY","SCROLLWHEEL UP","LEFT STICK"),
            new ButtonData(336, "INPUT_VEH_SLOWMO_DOWN_ONLY","SCROLLWHEEL DOWN","LEFT STICK"),
            new ButtonData(337, "INPUT_VEH_HYDRAULICS_CONTROL_TOGGLE","X","A"),
            new ButtonData(338, "INPUT_VEH_HYDRAULICS_CONTROL_LEFT","A","LEFT STICK"),
            new ButtonData(339, "INPUT_VEH_HYDRAULICS_CONTROL_RIGHT","D","LEFT STICK"),
            new ButtonData(340, "INPUT_VEH_HYDRAULICS_CONTROL_UP","LEFT SHIFT","LEFT STICK"),
            new ButtonData(341, "INPUT_VEH_HYDRAULICS_CONTROL_DOWN","LEFT CTRL","LEFT STICK"),
            new ButtonData(342, "INPUT_VEH_HYDRAULICS_CONTROL_UD","D","LEFT STICK"),
            new ButtonData(343, "INPUT_VEH_HYDRAULICS_CONTROL_LR","LEFT CTRL","LEFT STICK"),
            new ButtonData(344, "INPUT_SWITCH_VISOR","F11","DPAD RIGHT"),
            new ButtonData(345, "INPUT_VEH_MELEE_HOLD","X","A"),
            new ButtonData(346, "INPUT_VEH_MELEE_LEFT","LEFT MOUSE","BUTTON LB"),
            new ButtonData(347, "INPUT_VEH_MELEE_RIGHT","RIGHT MOUSE","BUTTON RB"),
            new ButtonData(348, "INPUT_MAP_POI","SCROLLWHEEL BUTTON","(PRESS) Y"),
            new ButtonData(349, "INPUT_REPLAY_SNAPMATIC_PHOTO","TAB","X"),
            new ButtonData(350, "INPUT_VEH_CAR_JUMP","E","L3"),
            new ButtonData(351, "INPUT_VEH_ROCKET_BOOST","E","L3"),
            new ButtonData(352, "INPUT_VEH_FLY_BOOST","LEFT","SHIFT L3"),
            new ButtonData(353, "INPUT_VEH_PARACHUTE","SPACEBAR","A"),
            new ButtonData(354, "INPUT_VEH_BIKE_WINGS","X","A"),
            new ButtonData(355, "INPUT_VEH_FLY_BOMB_BAY","E","DPAD RIGHT"),
            new ButtonData(356, "INPUT_VEH_FLY_COUNTER","E","DPAD RIGHT"),
            new ButtonData(357, "INPUT_VEH_TRANSFORM","X","A"),

        };


        private static string modVersion = "4.0";
        private static Vector3 Lab_LiquorAce = new Vector3(1388.91589f, 3604.7207f, 37.9390f);
        private static Vector3 Lab_LiquorAce_doors = new Vector3(1394.26f, 3599.63f, 34.02f);
        private static int CookingCooldown = 0;
        private static int TimerCounter = 0;
        private static int Customer = 0;
        private static int OnDeal = 0;
        private static int Supplier = 0;
        private static int OnSupply = 0;
        private static float TimerTarget = 100000;
        private static int LastCustomer = 0;
        private static int LastSupplier = 0;
        private static int currentSupplyDeal;
        private static int tempSupply = 1;
        private static int readyToRob = 0;
        private static int readyToPoliceSetup = 0;
        private static int saveToggle = 1;
        private static int propSpawn = 0;
        private static int TriggerPedCheck = 0;
        private static int WasBeingRobbed = 0;
        private static int WasBeingPoliceSetup = 0;
        public enum Nodetype { AnyRoad, Road, Offroad, Water }
        private static int OnLabraid = 0;
        private static int labraidfailed = 0;
        private static int labraidCooldown = 0;

        private static int hashTimerTarget = 1000;
        private static int hashTimerCounter = 0;

        private static int timen;
        private static int Passed_SelectedIndex = -1;
        private static int Scale;
        private static string scaleform_top;
        private static string scaleform_bottom;
        private static int scaleform_colour;
        private static string scaleform_sound;

        private static Vector3 deal1location = new Vector3(905.5829f, 3614.969f, 32.81862f);
        private static Vector3 deal2location = new Vector3(2363.88f, 3119.749f, 48.20966f);
        private static Vector3 deal3location = new Vector3(2878.413f, 3686.557f, 48.20292f);
        private static Vector3 deal4location = new Vector3(1964.085f, 5172.845f, 47.80671f);
        private static Vector3 deal5location = new Vector3(100.7299f, 6847.384f, 16.04326f);
        private static Vector3 deal6location = new Vector3(119.4116f, -1198.594f, 29.29514f);
        private static Vector3 deal7location = new Vector3(-3193.423f, 1231.214f, 10.04833f);
        private static Vector3 deal8location = new Vector3(1213.307f, 2643.646f, 37.80995f);
        private static Vector3 deal9location = new Vector3(1684.572f, 3288.351f, 41.14653f);
        private static Vector3 deal10location = new Vector3(2162.119f, 2117.68f, 125.9504f);
        private static Vector3 deal11location = new Vector3(2594.258f, 3170.011f, 51.03237f);
        private static Vector3 deal12location = new Vector3(-382.9714f, 3964.177f, 57.44019f);
        private static Vector3 deal13location = new Vector3(1642.083f, 4835.897f, 42.02521f);
        private static Vector3 deal14location = new Vector3(1311.5f, 4326.893f, 38.11893f);
        private static Vector3 deal15location = new Vector3(726.8161f, 4169.482f, 40.70921f);

        private static Vector3 supply1location = new Vector3(35.95f, 3717.88f, 38.8f);
        private static Vector3 supply2location = new Vector3(2329.609f, 3255.701f, 46.4f);

        private readonly ScriptSettings config;

        private static int activate_key;
        private static int quit_key;
        private static int anywhere_key;
        private static int quit_key_toggle;
        private static int accessanywhere;
        private static Ped deal1ped1;
        private static Ped deal1ped2;
        private static Ped deal1ped3;
        private static Ped deal1ped4;
        private static Ped deal2ped1;
        private static Ped deal2ped2;
        private static Ped deal3ped1;
        private static Ped deal3ped2;
        private static Ped deal4ped1;
        private static Ped deal4ped2;
        private static Ped deal4ped3;
        private static Ped deal5ped1;
        private static Ped deal6ped1;
        private static Ped deal6ped2;
        private static Ped deal7ped1;
        private static Ped deal8ped1;
        private static Ped deal8ped2;
        private static Ped deal8ped3;
        private static Ped deal9ped1;
        private static Ped deal9ped2;
        private static Ped deal10ped1;
        private static Ped deal10ped2;
        private static Ped deal11ped1;
        private static Ped deal11ped2;
        private static Ped deal11ped3;
        private static Ped deal11ped4;
        private static Ped deal11ped5;
        private static Ped deal11ped6;
        private static Ped deal11ped7;
        private static Ped deal12ped1;
        private static Ped deal12ped2;
        private static Ped deal12ped3;
        private static Ped deal12ped4;
        private static Ped deal12ped5;
        private static Ped deal12ped6;
        private static Ped deal13ped1;
        private static Ped deal13ped2;
        private static Ped deal14ped1;
        private static Ped deal14ped2;
        private static Ped deal14ped3;
        private static Ped deal14ped4;
        private static Ped deal15ped1;
        private static Vehicle deal1vehicle1;
        private static Vehicle deal2vehicle1;
        private static Vehicle deal3vehicle1;
        private static Vehicle deal4vehicle1;
        private static Vehicle deal5vehicle1;
        private static Vehicle deal8vehicle1;
        private static Vehicle deal10vehicle1;
        private static Vehicle deal11vehicle1;
        private static Vehicle deal11vehicle2;
        private static Vehicle deal11vehicle3;
        private static Vehicle deal11vehicle4;
        private static Vehicle deal11vehicle5;
        private static Vehicle deal11vehicle6;
        private static Vehicle deal11vehicle7;
        private static Vehicle deal12vehicle1;
        private static Vehicle deal12vehicle2;
        private static Vehicle deal13vehicle1;
        private static Vehicle deal14vehicle1;

        private static Prop supply1crate;
        private static Vehicle supply1vehicle1;
        private static Vehicle supply1vehicle2;
        private static Vehicle supply1vehicle3;
        private static Ped supply1ped1;
        private static Ped supply1ped2;
        private static Ped supply1ped3;
        private static Ped supply1ped4;
        private static Ped supply1ped5;

        private static Prop supply2crate;
        private static Vehicle supply2vehicle1;
        private static Ped supply2ped1;
        private static Ped supply2ped2;

        private static Vehicle supply100vehicle1;
        private static Vehicle supply100vehicle2;
        private static Vehicle supply100vehicle3;
        private static Vehicle supply100vehicle4;
        private static Vehicle supply100vehicle5;
        private static Vehicle supply100vehicle6;

        private static Ped supply100ped1;
        private static Ped supply100ped2;
        private static Ped supply100ped3;
        private static Ped supply100ped4;
        private static Ped supply100ped5;
        private static Ped supply100ped6;
        private static Ped supply100ped7;
        private static Ped supply100ped8;
        private static Ped supply100ped9;
        private static Ped supply100ped10;

        private static Prop supply101crate1;
        private static Prop supply101crate2;
        private static Prop supply101crate3;
        private static Ped supply101ped1;
        private static Ped supply101ped2;
        private static Ped supply101ped3;
        private static Ped supply101ped4;
        private static Ped supply101ped5;
        private static Ped supply101ped6;
        private static Vehicle supply101vehicle1;
        private static Vehicle supply101vehicle2;
        private static Vehicle supply101vehicle3;
        private static Vehicle supply101vehicle4;

        private static Ped setup1ped1;
        private static Ped setup1ped2;
        private static Ped setup1ped3;
        private static Vehicle setup1vehicle1;
        private static Vehicle setup1vehicle2;
        private static Vehicle setup1vehicle3;

        private static Prop methbagprop;

        private static int supply100_p1 = 0;
        private static int supply100_p2 = 0;
        private static int supply100_p3 = 0;
        private static Blip bl;

        private static int supply101_p1 = 0;
        private static int supply101_p2 = 0;
        private static int supply101_p3 = 0;

        private static Vector3 supply100_marker1 = new Vector3(1731.418f, 3308.002f, 40.22349f);
        private static Vector3 supply100_marker2 = new Vector3(1739.601f, 3299.628f, 40.22349f);
        private static Vector3 supply100_marker3 = new Vector3(1380.21f, 3600.34f, 33.86f);

        private static Vector3 supply101_marker1 = new Vector3(914.46f, 3216.3f, 36.88f);
        private static Vector3 supply101_marker2 = new Vector3(919.05f, 3225.41f, 36.82f);
        private static Vector3 supply101_marker3 = supply100_marker3;

        private readonly Ped playerPed = Game.Player.Character;
        private readonly Player player = Game.Player;
        private LemonUI.ObjectPool _menuPool;

        private static int currentSupplies = 0;
        private static int currentGrams = 0;
        private static int currentDealGrams = 0;

        private static int priceGram;
        private static int dealGramsMin;
        private static int cookGramsMin;
        private static int cookGramsMax;
        private static int cookLargeGramsMin;
        private static int cookLargeGramsMax;
        private static int cookGramsMin_Original;
        private static int cookGramsMax_Original;
        private static int cookLargeGramsMin_Original;
        private static int cookLargeGramsMax_Original;
        private static int supplyPrice;
        private static int upgradePrice;
        private static int upgradeMult;
        private static int upgradeCount = 0;

        private static Prop decorProp1;
        private static Prop decorProp2;
        private static Prop decorProp3;
        private static Prop decorProp4;
        private static Prop decorProp5;
        private static Prop decorProp6;
        private static Prop decorProp7;
        private static Prop decorProp8;
        private static Prop decorProp9;
        private static Prop decorProp10;
        private static Prop decorProp11;
        private static Prop decorProp12;
        private static Prop decorProp13;
        private static Prop decorProp14;
        private static Prop decorProp15;
        private static Prop decorProp16;
        private static Prop decorProp17;
        private static Prop decorProp18;
        private static Prop decorProp19;
        private static Prop decorProp20;
        private static Prop decorProp21;
        private static Prop decorProp22;
        private static Prop decorProp23;
        private static Prop decorProp24;
        private static Prop decorProp25;
        private static Prop decorProp26;
        private static Prop decorProp27;
        private static Prop decorProp28;
        private static Prop decorProp29;
        private static Prop decorProp30;
        private static Prop decorProp31;
        private static Prop decorProp32;
        private static Prop decorProp33;
        private static Prop decorProp34;
        private static Prop decorProp35;

        private static int OnUpgrade;
        private static int UpgradeMission;
        private static int LastUpgrade;

        private static int upgrade1_part;
        private static int upgrademission1counter = 0;
        private static int upgrademission2counter = 0;
        private static int upgrademission21counter = 0;
        private static int upgrademission22counter = 0;
        private static int upgrademission3counter = 0;

        private static Vehicle upgrade1vehicle1;
        private static Vehicle upgrade1vehicle2;
        private static Vehicle upgrade1vehicle3;
        private static Vehicle upgrade1vehicle4;
        private static Vehicle upgrade1vehicle5;
        private static Vehicle upgrade1vehicle6;
        private static Vehicle upgrade1vehicle7;
        private static Vehicle upgrade1vehicle8;
        private static Vehicle upgrade1vehicle9;
        private static Ped upgrade1ped1;
        private static Ped upgrade1ped2;
        private static Ped upgrade1ped3;
        private static Ped upgrade1ped4;
        private static Ped upgrade1ped5;
        private static Ped upgrade1ped6;
        private static Ped upgrade1ped7;
        private static Ped upgrade1ped8;
        private static Ped upgrade1ped9;
        private static Ped upgrade1ped10;
        private static Ped upgrade1ped11;
        private static Ped upgrade1ped12;
        private static Ped upgrade1ped13;
        private static Ped upgrade1ped14;
        private static Ped upgrade1ped15;
        private static Ped upgrade1ped16;
        private static Ped upgrade1ped17;
        private static Ped upgrade1ped18;
        private static Prop upgrade1barrel1;
        private static Prop upgrade1barrel2;
        private static Prop upgrade1barrel3;
        private static Vector3 upgrade1_marker1 = new Vector3(1525.94f, 1718.36f, 108.98f);
        private static Vector3 upgrade1_marker2 = supply100_marker3;

        private static Vehicle upgrade2vehicle1;
        private static Vehicle upgrade2vehicle2;
        private static Vehicle upgrade2vehicle3;
        private static Vehicle upgrade2vehicle4;
        private static Vehicle upgrade2vehicle5;
        private static Vehicle upgrade2vehicle6;
        private static Vehicle upgrade2vehicle7;
        private static Vehicle upgrade2vehicle8;
        private static Vehicle upgrade2vehicle9;
        private static Vehicle upgrade2vehicle10;
        private static Ped upgrade2ped1;
        private static Ped upgrade2ped2;
        private static Ped upgrade2ped3;
        private static Ped upgrade2ped4;
        private static Ped upgrade2ped5;
        private static Ped upgrade2ped6;
        private static Ped upgrade2ped7;
        private static Ped upgrade2ped8;
        private static Ped upgrade2ped9;
        private static Ped upgrade2ped10;
        private static Ped upgrade2ped11;
        private static Ped upgrade2ped12;
        private static int upgrade2_part;
        private static Vector3 upgrade2_marker1 = new Vector3(239.12f, 3152.59f, 41.41f);
        private static Vector3 upgrade2_marker2  = supply100_marker3;

        private static Vehicle upgrade3vehicle1;
        private static Vehicle upgrade3vehicle2;
        private static Vehicle upgrade3vehicle3;
        private static Vehicle upgrade3vehicle4;
        private static Vehicle upgrade3vehicle5;
        private static Vehicle upgrade3vehicle6;
        private static Vehicle upgrade3vehicle7;
        private static Vehicle upgrade3vehicle8;
        private static Ped upgrade3ped1;
        private static Ped upgrade3ped2;
        private static Ped upgrade3ped3;
        private static Ped upgrade3ped4;
        private static Ped upgrade3ped5;
        private static Ped upgrade3ped6;
        private static Ped upgrade3ped7;
        private static Ped upgrade3ped8;
        private static Ped upgrade3ped9;
        private static Ped upgrade3ped10;
        private static Ped upgrade3ped11;
        private static Ped upgrade3ped12;
        private static Ped upgrade3ped13;
        private static Prop upgrade3crate1;
        private static int upgrade3_part;
        private static Vector3 upgrade3_marker1 = new Vector3(1360.49f, 4366.78f, 43.34f);
        private static Vector3 upgrade3_marker2 = supply100_marker3;

        private static Vehicle upgrade4vehicle1;
        private static Vehicle upgrade4vehicle2;
        private static Vehicle upgrade4vehicle3;
        private static Vehicle upgrade4vehicle4;
        private static Vehicle upgrade4vehicle5;
        private static Vehicle upgrade4vehicle6;
        private static Vehicle upgrade4vehicle7;
        private static Vehicle upgrade4vehicle8;
        private static Vehicle upgrade4vehicle9;
        private static Vehicle upgrade4vehicle10;
        private static Vehicle upgrade4vehicle11;
        private static Vehicle upgrade4vehicle12;
        private static Vehicle upgrade4vehicle13;
        private static Ped upgrade4ped1;
        private static Ped upgrade4ped2;
        private static Ped upgrade4ped3;
        private static Ped upgrade4ped4;
        private static Ped upgrade4ped5;
        private static Ped upgrade4ped6;
        private static Ped upgrade4ped7;
        private static Ped upgrade4ped8;
        private static Ped upgrade4ped9;
        private static Ped upgrade4ped10;
        private static Ped upgrade4ped11;
        private static Ped upgrade4ped12;
        private static Ped upgrade4ped13;
        private static Ped upgrade4ped14;
        private static Ped upgrade4ped15;
        private static Ped upgrade4ped16;
        private static Ped upgrade4ped17;
        private static Ped upgrade4ped18;
        private static Ped upgrade4ped19;
        private static Ped upgrade4ped20;
        private static Ped upgrade4ped21;
        private static Ped upgrade4ped22;
        private static Ped upgrade4ped23;
        private static Ped upgrade4ped24;
        private static Ped upgrade4ped25;
        private static int upgrade4_part;
        private static int upgrade4_targetspot = 0;
        private static int upgrade4_targetspooked = 0;

        private static Ped labraidped1;
        private static Ped labraidped2;
        private static Ped labraidped3;
        private static Ped labraidped4;
        private static Ped labraidped5;
        private static Ped labraidped6;
        private static Ped labraidped7;
        private static Ped labraidped8;
        private static int labRaidToggle;
        private static int labRaidFreq;

        private static Prop upgrade5crate1;
        private static Vehicle upgrade5vehicle1;
        private static Vehicle upgrade5vehicle2;
        private static Vehicle upgrade5vehicle3;
        private static Vehicle upgrade5vehicle4;
        private static Ped upgrade5ped1;
        private static Ped upgrade5ped2;
        private static Ped upgrade5ped3;
        private static Ped upgrade5ped4;
        private static Ped upgrade5ped5;
        private static Ped upgrade5ped6;
        private static Ped upgrade5ped7;
        private static Ped upgrade5ped8;
        private static Ped upgrade5ped9;
        private static Ped upgrade5ped10;
        private static Ped upgrade5ped11;
        private static Ped upgrade5ped12;
        private static Ped upgrade5ped13;
        private static int upgrade5_part;
        private static Vector3 upgrade5_marker1 = new Vector3(1394.63f, 3598.72f, 33.99f);

        private static Vehicle upgrade6vehicle1;
        private static Vehicle upgrade6vehicle2;
        private static Vehicle upgrade6vehicle3;
        private static Vehicle upgrade6vehicle4;
        private static Vehicle upgrade6vehicle5;
        private static Vehicle upgrade6vehicle6;
        private static Vehicle upgrade6vehicle7;
        private static Vehicle upgrade6vehicle8;
        private static Vehicle upgrade6vehicle9;
        private static Ped upgrade6ped1;
        private static Ped upgrade6ped2;
        private static Ped upgrade6ped3;
        private static Ped upgrade6ped4;
        private static Ped upgrade6ped5;
        private static Ped upgrade6ped6;
        private static Ped upgrade6ped7;
        private static int upgrade6_part;
        private static Vector3 upgrade6_marker1 = new Vector3(1705.66f, 3251.06f, 40.01f);

        private static Vehicle upgrade7vehicle1;
        private static Vehicle upgrade7vehicle2;
        private static Vehicle upgrade7vehicle3;
        private static Vehicle upgrade7vehicle4;
        private static Ped upgrade7ped1;
        private static Ped upgrade7ped2;
        private static Ped upgrade7ped3;
        private static Ped upgrade7ped4;
        private static Ped upgrade7ped5;
        private static Ped upgrade7ped6;
        private static Ped upgrade7ped7;
        private static Ped upgrade7ped8;
        private static Ped upgrade7ped9;
        private static Ped upgrade7ped10;
        private static int upgrade7_part;
        private static Vector3 upgrade7_markerhumane = new Vector3(3629.81f, 3759.93f, 27.52f);
        private static Vector3 upgrade7_markerlab = supply100_marker3;
        private static Vector3 upgrade7_loadpoint = new Vector3(1746f, 3776.89f, 33.02f);

        private static Vehicle upgrade8vehicle1;
        private static Prop upgrade8crate1;
        private static int upgrade8_part;
        private static int upgrade8dropwait = 0;
        private static Vector3 upgrade8_dropzone1 = new Vector3(618.498f, 2945.722f, 39.34f);
        private static Vector3 upgrade8_dropzone2 = new Vector3(41.21515f, 3330.998f, 36.52f);
        private static Vector3 upgrade8_dropzone3 = new Vector3(-318.8817f, 2732.809f, 67.52f);
        private static Vector3 upgrade8_dropzone4 = new Vector3(826.4474f, 2142.386f, 51.21f);
        private static Vector3 upgrade8_dropzone5 = new Vector3(1456.043f, 1113.066f, 113.3f);
        private static Vector3 upgrade8_dropzone6 = new Vector3(2349.818f, 3096.454f, 46.92f);
        private static Prop upgrade8flare1;
        public static List<Prop> upgrade8crates = new List<Prop>();

        private static Vehicle upgrade9vehicle1;
        private static Vehicle upgrade9vehicle2;
        private static Vehicle upgrade9vehicle3;
        private static Vehicle upgrade9vehicle4;
        private static Vehicle upgrade9vehicle5;
        private static Vehicle upgrade9vehicle6;
        private static Ped upgrade9ped1;
        private static Ped upgrade9ped2;
        private static Ped upgrade9ped3;
        private static Ped upgrade9ped4;
        private static Ped upgrade9ped5;
        private static Ped upgrade9ped6;
        private static Ped upgrade9ped7;
        private static Ped upgrade9ped8;
        private static Ped upgrade9ped9;
        private static Ped upgrade9ped10;
        private static Ped upgrade9ped11;
        private static Ped upgrade9ped12;
        private static Ped upgrade9ped13;
        private static Ped upgrade9ped14;
        private static int upgrade9_part;
        private static float upgrade9cameracounter;
        private static Vector3 upgrade9_marker1 = new Vector3(2057.035f, 3178.679f, 44.16895f);
        private static Vector3 upgrade9_markerlab = supply100_marker3;
        private static Vector3 upgrade9_markerjumpdesert = new Vector3(1778.425f, 3306.158f, 40.28658f);
        private static Vector3 upgrade9_markerjumpfirestation = new Vector3(1716.53f, 3592.131f, 34.30729f);
        private static Vector3 upgrade9_markeryellowjack = new Vector3(1981.84f, 3035.22f, 46.06f);

        private static Vehicle upgrade10vehicle1;
        private static Vehicle upgrade10vehicle2;
        private static Vehicle upgrade10vehicle3;
        private static Vehicle upgrade10vehicle4;
        private static Ped upgrade10ped1;
        private static Ped upgrade10ped2;
        private static Ped upgrade10ped3;
        private static Ped upgrade10ped4;
        private static Ped upgrade10ped5;
        private static Ped upgrade10ped6;
        private static Ped upgrade10ped7;
        private static Ped upgrade10ped8;
        private static Ped upgrade10ped9;
        private static int upgrade10_part;

        private static int robberyFreq_orig;
        private static int policeFreq_orig;
        private static int robberybulkFreq_orig;
        private static int policebulkFreq_orig;

        private static int robberyFreq;
        private static int policeFreq;
        private static int robberybulkFreq;
        private static int policebulkFreq;

        private static int killerHash = 0;

        private static int cookSmallTimeDay;

        private static int large2BatchStart = 0;
        private static int largeBatchStart = 0;
        private static int smallBatchStart = 0;
        private static float TimerCounterAutoBatch = 0;

        private static int upgradePropStatus = 0;

        public static List<int> Props = new List<int>();

        public static List<int> previousCustomers = new List<int>();

        private static string savepath = "scripts\\MethDealing.ini";

        private static int dealNeverWanted;
        private static int upgradeNeverWanted;
        private static int supplyNeverWanted;
        private static int upgradeProps;
        private static int checkUpdateStartup;
        private static int labBlipToggle;
        private static int upgradeEnemyBlipToggle;

        private static bool perk1chef = false;
        private static bool perk2supplydeal = false;
        private static float perk2supplymultiplier = 1;
        private static bool perk3bluemeth = false;
        private static float perk3bluemethmultiplier = 1;
        private static bool perk4verylarge = false;
        private static bool perk5securityintel = false;
        private static bool perk6backgroundcheck = false;
        private static bool perk7hirecooks = false;

        private static int perk1price = 10000;
        private static int perk2price = 25000;
        private static int perk3price = 35000;
        private static int perk4price = 15000;
        private static int perk5price = 20000;
        private static int perk6price = 20000;
        private static int perk7price = 500000;
        private static int perk7interval = 500000;

        private static int menucolour_alpha = 200;
        private static int menucolour_red = 220;
        private static int menucolour_green = 0;
        private static int menucolour_blue = 0;

        private static int supply102_part;
        private static Vehicle supply102vehicle1;
        private static Vector3 supply102_marker1 = supply100_marker3;

        private static int supply103_part;
        private static Vehicle supply103vehicle1;
        private static Vehicle supply103vehicle2;
        private static Vehicle supply103vehicle3;
        private static Vector3 supply103_marker1 = supply100_marker3;

        private static Vehicle supply104vehicle1;
        private static Prop supply104crate1;
        private static Vector3 supply104_marker1 = new Vector3(1423.25f,3612.9f,33.97f);
        private static int supply104_part;

        private static Ped perk7ped1;
        private static Ped perk7ped2;

        private static bool upgrade7hostile = false;

        public static List<dynamic> SuppliesAmt = new List<dynamic>()
        {
            1, 10, 25, 50, 100, 250, 500, 1000, 2500, 5000,10000,
        };
        private LemonUI.Menus.NativeListItem<dynamic> getSuppliesItem = new LemonUI.Menus.NativeListItem<dynamic>("Arrange supply deal", SuppliesAmt.ToArray());
      

        public Meth()
        {
            GTA.UI.Notification.Show("~g~Meth Dealing~w~ Loaded by ~y~FelixTheBlackCat~w~\nConversion To LemonUI by~g~ HKH191~w~\nConversion Requested by ~b~Nosferatus IX");
            this.config = ScriptSettings.Load("scripts\\MethDealing_Settings.ini");
            //Keys
            Meth.activate_key = this.config.GetValue<int>("KEY", "MAINKEY", activate_key);
            Meth.quit_key_toggle = this.config.GetValue<int>("KEY", "ENABLEQUITKEY", 0);
            Meth.quit_key = this.config.GetValue<int>("KEY", "QUITKEY", quit_key);
            //Menu
            Meth.accessanywhere = this.config.GetValue<int>("MENU", "ACCESSANYWHERE", 1);
            Meth.anywhere_key = this.config.GetValue<int>("MENU", "ACCESSANYWHEREKEY", anywhere_key);
            //MENUCOLOUR
            Meth.menucolour_alpha = this.config.GetValue<int>("MENUCOLOUR", "ALPHA", 200);
            Meth.menucolour_red = this.config.GetValue<int>("MENUCOLOUR", "RED", 220);
            Meth.menucolour_green = this.config.GetValue<int>("MENUCOLOUR", "BLUE", 0);
            Meth.menucolour_blue = this.config.GetValue<int>("MENUCOLOUR", "GREEN", 0);
            //Deals
            Meth.priceGram = this.config.GetValue<int>("DEALS", "GRAMPRICE", 80);
            Meth.dealGramsMin = this.config.GetValue<int>("DEALS", "DEALMINGRAMS", 80);
            Meth.robberyFreq_orig = this.config.GetValue<int>("DEALS", "ROBBERYFREQ", 25);
            Meth.policeFreq_orig = this.config.GetValue<int>("DEALS", "POLICEFREQ", 25);
            Meth.robberybulkFreq_orig = this.config.GetValue<int>("DEALS", "BULKROBBERYFREQ", 21);
            Meth.policebulkFreq_orig = this.config.GetValue<int>("DEALS", "BULKPOLICEFREQ", 21);
            Meth.dealNeverWanted = this.config.GetValue<int>("DEALS", "NEVERWANTED", 0);
            //Cooking
            Meth.cookGramsMin_Original = this.config.GetValue<int>("COOKING", "SMINGRAMS", 3);
            Meth.cookGramsMax_Original = this.config.GetValue<int>("COOKING", "SMAXGRAMS", 10);
            Meth.cookLargeGramsMin_Original = this.config.GetValue<int>("COOKING", "LMINGRAMS", 30);
            Meth.cookLargeGramsMax_Original = this.config.GetValue<int>("COOKING", "LMAXGRAMS", 100);
            Meth.cookSmallTimeDay = this.config.GetValue<int>("COOKING", "TIMECHANGE", 1);
            //Supplies
            Meth.supplyPrice = this.config.GetValue<int>("SUPPLIES", "SUPPLYPRICE", 20);
            Meth.supplyNeverWanted = this.config.GetValue<int>("SUPPLIES", "NEVERWANTED", 0);
            //Upgrades
            Meth.upgradePrice = this.config.GetValue<int>("UPGRADES", "UPGRADEPRICE", 0);
            Meth.upgradeMult = this.config.GetValue<int>("UPGRADES", "MULTIPLIER", 2);
            Meth.upgradeProps = this.config.GetValue<int>("UPGRADES", "UPGRADEPROPS", 1);
            Meth.upgradeNeverWanted = this.config.GetValue<int>("UPGRADES", "NEVERWANTED", 0);
            //Raids
            Meth.labRaidToggle = this.config.GetValue<int>("RAIDS", "LABRAID", 1);
            Meth.labRaidFreq = this.config.GetValue<int>("RAIDS", "RAIDFREQUENCY", 1);
            //Saves  
            Meth.saveToggle = this.config.GetValue<int>("SAVES", "STOGGLE", 1);
            //Updates  
            Meth.checkUpdateStartup = this.config.GetValue<int>("UPDATE", "CHECKATSTARTUP", 1);
            //Blips  
            Meth.labBlipToggle = this.config.GetValue<int>("BLIPS", "LABBLIP", 1);
            Meth.upgradeEnemyBlipToggle = this.config.GetValue<int>("BLIPS", "ENEMYBLIPS", 1);
            //Perks  
            Meth.perk1price = this.config.GetValue<int>("PERKS", "PERK1PRICE", 10000);
            Meth.perk2price = this.config.GetValue<int>("PERKS", "PERK2PRICE", 25000);
            Meth.perk3price = this.config.GetValue<int>("PERKS", "PERK3PRICE", 35000);
            Meth.perk4price = this.config.GetValue<int>("PERKS", "PERK4PRICE", 15000);
            Meth.perk5price = this.config.GetValue<int>("PERKS", "PERK5PRICE", 20000);
            Meth.perk6price = this.config.GetValue<int>("PERKS", "PERK6PRICE", 20000);
            Meth.perk7price = this.config.GetValue<int>("PERKS", "PERK7PRICE", 500000);
            Meth.perk7interval = this.config.GetValue<int>("PERKS", "PERK7INTERVAL", 300000);

            robberyFreq = robberyFreq_orig;
            policeFreq = policeFreq_orig;
            robberybulkFreq = robberybulkFreq_orig;
            policebulkFreq = policebulkFreq_orig;

            if (saveToggle == 1)
            {
                if (File.Exists(savepath))
                {
                    GTA.UI.Notification.Show("~r~Meth dealing V" + modVersion + "~w~ started. Save file found at ~g~" + savepath+".");
                    loadStats();
                }
                else
                {
                    GTA.UI.Notification.Show("~r~Meth dealing V" + modVersion + "~w~ started. Save file ~r~not found.");
                    saveStats();
                }
            }
            else
            {
                GTA.UI.Notification.Show("~r~Meth dealing V" +modVersion+ "~w~ started. Save file ~r~disabled.");
            }

            if (checkUpdateStartup == 1)
            {
                string updateVersion = checkUpdate();
                if (updateVersion == "Failed")
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~An error occured whilst checking for updates.");
                }
                else if (modVersion != updateVersion)
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                 //   GTA.UI.Notification.Show("~g~New update ready - please visit tiny.cc/gtameth to install V" + updateVersion + ".");
                }
                else
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                }
            }
            else
            {
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
            }

            startMenus();

            // Tick += (o, e) => _menuPool.AreAnyVisible;
            Tick += onTick;
            CreateBanner();
            Aborted += onShutdown;
         
            base.Interval = 1;
     
            upgradeLab();

            if (labBlipToggle == 1)
            {
                Meth.DrawLabBlips();
            }
        }
        public void onShutdown(object sender, EventArgs e)
        {
            if (MethLabBlip != null)
            {
                MethLabBlip.Delete();
            }
            upgradeLabPropDelete();
            foreach (Prop currentprop in getUpgradeProps())
            {
                if (currentprop != null && currentprop.Exists())
                {
                    currentprop.Delete();
                }
            }
            foreach (Vehicle currentvehicle in getUpgradeVehicles())
            {
                if (currentvehicle != null && currentvehicle.Exists())
                {
                    currentvehicle.Delete();
                }
            }
            foreach (Ped currentped in getUpgradePeds())
            {
                if (currentped != null && currentped.Exists())
                {
                    currentped.Delete();
                }
            }
            foreach (Vehicle currentvehicle in getDealVehicles())
            {
                if (currentvehicle != null && currentvehicle.Exists())
                {
                    currentvehicle.Delete();
                }
            }
            foreach (Ped currentped in getDealPeds())
            {
                if (currentped != null && currentped.Exists())
                {
                    currentped.Delete();
                }
            }
            cleanUp();
            if (bl != null)
            { bl.Delete(); }
        }
        public LemonUI.Elements.ScaledRectangle RectangleGUI = new LemonUI.Elements.ScaledRectangle(new Point(0, 0), new Size(0, 108));
        public LemonUI.Menus.NativeMenu MenuM2;
        public List<LemonUI.Menus.NativeMenu> GLemonUIMenusNativeMenus = new List<LemonUI.Menus.NativeMenu>();

        public void SetBanner(LemonUI.Menus.NativeMenu menu)
        {
            menu.Banner = RectangleGUI; ;
        }
        public void CreateBanner()
        {
            RectangleGUI = new LemonUI.Elements.ScaledRectangle(new Point(0, 0), new Size(0, 108)); ;
            RectangleGUI.Color = Color.FromArgb(menucolour_alpha, menucolour_red, menucolour_blue, menucolour_green);
        }
        //Menus------------------
        private static LemonUI.Menus.NativeMenu mainMenu = new LemonUI.Menus.NativeMenu("Meth Lab", "");

        public void cookMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu cookMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Manufacture");
            menu.AddSubMenu(cookMenu);
            _menuPool.Add(cookMenu);
            for (int i = 0; i < 1; i++) ;

            SetBanner(cookMenu);

            var cookmethitem = new LemonUI.Menus.NativeItem("Start cooking small batch", "This requires 1x supplies.");
            cookMenu.Add(cookmethitem);
            var cookmethbigitem = new LemonUI.Menus.NativeItem("Start cooking large batch", "This requires 10x supplies.");
            cookMenu.Add(cookmethbigitem);
            var cookmethbigbigitem = new LemonUI.Menus.NativeItem("Start cooking very large batch", "This requires 50x supplies.");
            cookMenu.Add(cookmethbigbigitem);
            cookmethitem.Activated += (sender, item) =>
            {
                if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) > 3.5 && perk1chef == false)
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~You are too far away from your lab to cook right now.");
                }
                else
                {
                    if (largeBatchStart == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~Your lab is currently in use to cook a large batch.");
                    }
                    else if (Meth.CookingCooldown == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on cooldown, please wait and try again later.");
                    }
                    else if (Meth.OnDeal == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on deal, please complete or cancel the deal and try again.");
                    }
                    else if (Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on a supply mission, please complete or cancel the deal and try again.");
                    }
                    else if (currentSupplies <= 0)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You currently have no supplies, please purchase more and try again.");
                    }
                    else
                    {
                        cookmeth();
                    }
                }
            };
            cookmethbigitem.Activated += (sender, item) =>
            {
                if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) > 3.5 && perk1chef == false)
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~You are too far away from your lab to cook right now.");
                }
                else
                {
                    if (Meth.CookingCooldown == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on cooldown, please wait and try again later.");
                    }
                    else if (Meth.OnDeal == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on deal, please complete or cancel the deal and try again.");
                    }
                    else if (Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on a supply mission, please complete or cancel the deal and try again.");
                    }
                    else if (largeBatchStart == 1 || large2BatchStart == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~Your lab is currently in use to cook a large batch.");
                    }
                    else if (currentSupplies < 10)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You need at least ~b~10x supplies~r~, please purchase more and try again.");
                    }
                    else
                    {
                        cookmethlarge();
                    }
                }
            };
            cookmethbigbigitem.Activated += (sender, item) =>
            {
                if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) > 3.5 && perk1chef == false)
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~You are too far away from your lab to cook right now.");
                }
                else
                {
                    if (perk4verylarge == false)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You must purchase the perk 'Bigger bucket' to unlock this.");
                    }
                    else if (Meth.CookingCooldown == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on cooldown, please wait and try again later.");
                    }
                    else if (Meth.OnDeal == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on deal, please complete or cancel the deal and try again.");
                    }
                    else if (Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are on a supply mission, please complete or cancel the deal and try again.");
                    }
                    else if (largeBatchStart == 1 || large2BatchStart == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~Your lab is currently in use to cook a large batch.");
                    }
                    else if (currentSupplies < 50)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You need at least ~b~50x supplies~r~, please purchase more and try again.");
                    }
                    else
                    {
                        cookmethverylarge();
                    }
                }
            };




        }

        public void sellMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu sellMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Distribution");
            menu.AddSubMenu(sellMenu);
            _menuPool.Add(sellMenu);
            Random random = new Random();
        
            for (int i = 0; i < 1; i++) ;

            SetBanner(sellMenu);

            var sellProductItem = new LemonUI.Menus.NativeItem("Arrange deal", "");
            sellMenu.Add(sellProductItem);
            var sellBBulkItem = new LemonUI.Menus.NativeItem("Bulk sell all product", "");
            sellMenu.Add(sellBBulkItem);
            var checkProductItem = new LemonUI.Menus.NativeItem("Check product stock", "");
            sellMenu.Add(checkProductItem);
            //Was OnItemSelect

            sellProductItem.Activated += (sender, item) =>
          {
              if (currentGrams >= dealGramsMin && OnDeal == 0)
              {
                  deleteScene(LastCustomer);
                  Meth.DoCustomer();
                  OnDeal = 1;
                  currentDealGrams = random.Next(dealGramsMin, currentGrams + 1);

                  Random rnd = new Random();
                  int chooser = rnd.Next(1, 6);
                  string msg2do = "";
                  if (chooser == 1)
                  {
                      msg2do = "Drive to the ~b~deal location~w~ to sell " + currentDealGrams + "g of meth for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                  }
                  else if (chooser == 2)
                  {
                      msg2do = "Head to the ~b~deal location~w~ to drop off " + currentDealGrams + "g of meth for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                  }
                  else if (chooser == 3)
                  {
                      msg2do = "Get to the ~b~deal location~w~ to drop off " + currentDealGrams + "g of meth and get paid ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                  }
                  else if (chooser == 4)
                  {
                      msg2do = "Drop off " + currentDealGrams + "g to the buyer at the ~b~deal location~w~ for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                  }
                  else if (chooser == 5)
                  {
                      msg2do = "The buyer wants " + currentDealGrams + "g of meth. Drop it off at the ~b~deal location~w~ for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                  }
                  TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                  if (quit_key_toggle == 1)
                  {
                      GTA.UI.Notification.Show("Hit " + ReturnButtonString(quit_key).ToString() + " to cancel the deal.");
                  }

                  chooser = rnd.Next(1, robberyFreq);
                  if (chooser == 1)
                  {
                      readyToRob = 1;
                  }
                  chooser = rnd.Next(1, policeFreq);
                  if (chooser == 1 && readyToRob != 1 && dealNeverWanted == 0)
                  {
                      readyToPoliceSetup = 1;
                  }
              }
              else if (currentGrams < dealGramsMin && OnDeal == 0)
              {
                  Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                  GTA.UI.Notification.Show("~r~You need at least " + dealGramsMin + "g of meth ready to start a deal.");
              }
              else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
              {
                  Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                  GTA.UI.Notification.Show("~r~You are already on a deal, please complete or cancel the deal and try again.");
              }
          };
            sellBBulkItem.Activated += (sender, item) =>
             {
                 if (currentGrams >= cookGramsMax * 5 && OnDeal == 0)
                 {
                     deleteScene(LastCustomer);
                     Meth.DoCustomer();
                     currentDealGrams = currentGrams;
                     Random rnd = new Random();
                     int chooser = rnd.Next(1, 4);
                     string msg2do = "";
                     if (chooser == 1)
                     {
                         msg2do = "Set up a bulk deal. Get to the ~b~deal location~w~ to sell " + currentDealGrams + "g of meth for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                     }
                     else if (chooser == 2)
                     {
                         msg2do = "I just got a call from a buyer wanting " + currentDealGrams + "g for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier))) + "~w~. Go to the ~b~deal location~w~.";
                     }
                     else if (chooser == 3)
                     {
                         msg2do = "Found a buyer after " + currentDealGrams + "g of meth. Go to the ~b~deal location~w~ to drop it off for ~g~$" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)));
                     }
                     TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                     if (quit_key_toggle == 1)
                     {
                         GTA.UI.Notification.Show("Hit " + ReturnButtonString(quit_key) + " to cancel the deal.");
                     }

                     chooser = rnd.Next(1, robberybulkFreq);
                     if (chooser == 1)
                     {
                         readyToRob = 1;
                     }
                     chooser = rnd.Next(1, policebulkFreq);
                     if (chooser == 1 && readyToRob != 1 && dealNeverWanted == 0)
                     {
                         readyToPoliceSetup = 1;
                     }
                 }
                 else if (currentGrams < cookGramsMax * 5 && OnDeal == 0)
                 {
                     Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                     GTA.UI.Notification.Show("~r~You need at least " + cookGramsMax * 5 + "g of meth ready to bulk sell.");
                 }
                 else if (OnDeal == 1)
                 {
                     Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                     GTA.UI.Notification.Show("~r~You are already on a deal. Cancel the deal by hitting " + Meth.quit_key.ToString() + ".");
                 }

             };
             checkProductItem.Activated += (sender, item) =>
                {
                    GTA.UI.Notification.Show("You currently have ~g~" + currentGrams + "g ~w~of meth cooked and ready to sell.");
                };
            
        }
        public bool IntToBool(int i)
        {
            bool B = false;
            if (i == 0)
            {
                B = false;
            }
            if (i == 1)
            {
                B = true;
            }
            return B;
        }
        public void suppliesMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu suppliesMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Supplies");
            menu.AddSubMenu(suppliesMenu);
            _menuPool.Add(suppliesMenu);
            for (int i = 0; i < 1; i++) ;

            SetBanner(suppliesMenu);
            suppliesMenu.Add(getSuppliesItem);
            var checkSuppliesItem = new LemonUI.Menus.NativeItem("Check supply stock", "");
            suppliesMenu.Add(checkSuppliesItem);

            //Was OnItemSelect

            getSuppliesItem.Activated += (sender, item) =>
          {
              if (Meth.OnSupply == 0)
              {
                  currentSupplyDeal = tempSupply;
                  if (Game.Player.Money >= currentSupplyDeal * (Convert.ToInt32(Math.Ceiling(Convert.ToDouble(supplyPrice) / perk2supplymultiplier))))
                  {
                      deleteSceneSupply(LastSupplier);
                      Game.Player.Money -= currentSupplyDeal * Convert.ToInt32(Math.Ceiling(Convert.ToDouble(supplyPrice) / perk2supplymultiplier));
                      if (currentSupplyDeal >= 250)
                      {
                          deleteSceneSupply(LastSupplier);
                          DoSupplierLarge();

                          if (quit_key_toggle == 1)
                          {
                              GTA.UI.Notification.Show("Hit " + ReturnButtonString(quit_key) + " to cancel the deal.");
                          }
                      }
                      else
                      {
                          Random rnd = new Random();
                          int chooser = rnd.Next(1, 6);
                          string msg2do = "";
                          if (chooser == 1)
                          {
                              msg2do = "I've purchased ~b~" + currentSupplyDeal.ToString() + "x ~w~supplies from our guy, the product is waiting for you.";
                          }
                          else if (chooser == 2)
                          {
                              msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies purchased. They're waiting for you now.";
                          }
                          else if (chooser == 3)
                          {
                              msg2do = "Just bought ~b~" + currentSupplyDeal.ToString() + "x ~w~supplies for our business. Go pick them up.";
                          }
                          else if (chooser == 4)
                          {
                              msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are waiting for you now with the seller.";
                          }
                          else if (chooser == 5)
                          {
                              msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are awaiting transport from the pick up location.";
                          }
                          TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                          deleteSceneSupply(LastSupplier);
                          DoSupplier();
                      }
                  }
                  else
                  {
                      Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                      GTA.UI.Notification.Show("~r~You do not have enough money.");
                  }

              }
              else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
              {
                  Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                  GTA.UI.Notification.Show("~r~You are already on a deal, please complete or cancel the deal and try again.");
              }
            
          };
            checkSuppliesItem.Activated += (sender, item) =>
            {
                GTA.UI.Notification.Show("You currently have~b~ " + currentSupplies + " ~w~total supplies");
            };


            //Was OnListChange

            suppliesMenu.SelectedIndexChanged += (sender, item) =>
                {
                    tempSupply = Convert.ToInt32(suppliesMenu.SelectedIndex);
                };
            
        }

        public void upgradeLabMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu upgradeLabMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Upgrades");
            menu.AddSubMenu(upgradeLabMenu);
            _menuPool.Add(upgradeLabMenu);

            for (int i = 0; i < 1; i++) ;

            SetBanner(upgradeLabMenu);


            var checkUpgradeItem = new LemonUI.Menus.NativeItem("Check upgrade status");
            upgradeLabMenu.Add(checkUpgradeItem);
            var startUpgrade1 = new LemonUI.Menus.NativeItem("Mission 1", "Steal a Sandking loaded with chemicals to produce larger cook yields.");
            upgradeLabMenu.Add(startUpgrade1);
            var startUpgrade2 = new LemonUI.Menus.NativeItem("Mission 2", "Find a truck and steal a trailer loaded with lab equipment from an enemy gang.");
            upgradeLabMenu.Add(startUpgrade2);
            var startUpgrade3 = new LemonUI.Menus.NativeItem("Mission 3", "Head over to the town of Galilee and steal a crate strapped to the back of a Blazer.");
            upgradeLabMenu.Add(startUpgrade3);
            var startUpgrade4 = new LemonUI.Menus.NativeItem("Mission 4", "Take down an enemy gang boss at a local meet so you can expand in to their territory.");
            upgradeLabMenu.Add(startUpgrade4);
            var startUpgrade5 = new LemonUI.Menus.NativeItem("Mission 5", "Steal a crate of chemicals from a biker gang from the Sandy Shores motel near the lab.");
            upgradeLabMenu.Add(startUpgrade5);
            var startUpgrade6 = new LemonUI.Menus.NativeItem("Mission 6", "Take out several targets across Blaine County using a Hydra to show local gangs who's running things.");
            upgradeLabMenu.Add(startUpgrade6);
            var startUpgrade7 = new LemonUI.Menus.NativeItem("Mission 7", "Hijack a van full of lab equipment on its way to Humane Labs. Watch out for their security team!");
            upgradeLabMenu.Add(startUpgrade7);
            var startUpgrade8 = new LemonUI.Menus.NativeItem("Mission 8", "Drop off some packages from a heli for a friend of Ron, in return for some new lab chemicals.");
            upgradeLabMenu.Add(startUpgrade8);
            var startUpgrade9 = new LemonUI.Menus.NativeItem("Mission 9", "Locate an abandoned Mule truck full of methylamine to increase cooking yields.");
            upgradeLabMenu.Add(startUpgrade9);
            var startUpgrade10 = new LemonUI.Menus.NativeItem("Mission 10", "Take a ride across Blaine County and take out multiple enemy gang targets.");
            upgradeLabMenu.Add(startUpgrade10);

            //Was OnItemSelect


            checkUpgradeItem.Activated += (sender, item) =>
          {
              if (upgradeCount > 0)
              {
                  GTA.UI.Notification.Show("You have completed ~g~" + upgradeCount + "~w~ missions, upgrading cooking by ~g~" + upgradeCount * upgradeMult + "X.");
              }
              else
              {
                  GTA.UI.Notification.Show("~r~You have completed " + upgradeCount + " upgrade missions. Select a mission below to start upgrading your lab.");
                  Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");

              }
          };
           startUpgrade1.Activated += (sender, item) =>
           {
               { 
                    if (Meth.OnUpgrade == 0)
                  {
                      if (Game.Player.Money >= (upgradePrice))
                      {
                          deleteSceneUpgrade(LastUpgrade);
                          Game.Player.Money -= upgradePrice;
                          DoUpgrade(upgradeLabMenu.SelectedIndex);
                      }
                      else
                      {
                          Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                          GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                      }

                  }
                  else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                  {
                      Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                      GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                  }
              }
          };
            startUpgrade2.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade3.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade4.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade5.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade6.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade7.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade8.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade9.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
            startUpgrade10.Activated += (sender, item) =>
            {
                {
                    if (Meth.OnUpgrade == 0)
                    {
                        if (Game.Player.Money >= (upgradePrice))
                        {
                            deleteSceneUpgrade(LastUpgrade);
                            Game.Player.Money -= upgradePrice;
                            DoUpgrade(upgradeLabMenu.SelectedIndex);
                        }
                        else
                        {
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You need $" + upgradePrice + " to purchase an upgrade.");
                        }

                    }
                    else if (Meth.OnUpgrade == 1 || Meth.OnDeal == 1 || Meth.OnSupply == 1)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are already on a mission, please complete or cancel the mission and try again.");
                    }
                }
            };
  

        }

        public void perkMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu perkMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Perks");
            menu.AddSubMenu(perkMenu);
            _menuPool.Add(perkMenu);
            for (int i = 0; i < 1; i++) ;

            SetBanner(perkMenu);

            var perk1chefItem = new LemonUI.Menus.NativeCheckboxItem("Hire Chef", "Hire Chef to work in your lab. This will allow you to start batches from anywhere. Costs ~g~$"+perk1price+".");
            perkMenu.Add(perk1chefItem); perk1chefItem.Checked = perk1chef;
             var perk2supplyItem = new LemonUI.Menus.NativeCheckboxItem("Negotiation skills", "Ability to purchase supplies for ~b~25%~w~ less than the usual price. Costs ~g~$" + perk2price + ".");
            perkMenu.Add(perk2supplyItem); perk2supplyItem.Checked = perk2supplydeal;
            var perk3blueItem = new LemonUI.Menus.NativeCheckboxItem("Blue meth", "Start adding blue dye to your meth during production in order to increase the price per gram by ~b~20%~w~. Costs ~g~$" + perk3price + ".");
            perkMenu.Add(perk3blueItem); perk3blueItem.Checked = perk3bluemeth;
            var perk4veryItem = new LemonUI.Menus.NativeCheckboxItem("Bigger bucket", "Unlock the ability to cook even larger batches, using 50 supplies each time, by upgrading the size of your lab equipment. Costs ~g~$" + perk4price + ".");
            perkMenu.Add(perk4veryItem); perk4veryItem.Checked = perk4verylarge;
            var perk5securityItem = new LemonUI.Menus.NativeCheckboxItem("Security intel",  "Hire Ron's friends to keep tabs on the lab, greatly reducing the chance you are raided by enemy gangs whilst inside your lab. Costs ~g~$" + perk5price + ".");
            perkMenu.Add(perk5securityItem); perk5securityItem.Checked = perk5securityintel;
            var perk6backgroundItem = new LemonUI.Menus.NativeCheckboxItem("Background check",  "Start checking customer names against a leaked LAPD database, allowing you to cut the chance of being robbed/set up in half. Costs ~g~$" + perk6price + ".");
            perkMenu.Add(perk6backgroundItem); perk6backgroundItem.Checked = perk6backgroundcheck;
            var perk7hirecookItem = new LemonUI.Menus.NativeCheckboxItem("Hire cooks", "Hire some unemployed lab technicians to automatically cook batches for you. Costs ~g~$" + perk7price + ".");
            perkMenu.Add(perk7hirecookItem); perk7hirecookItem.Checked = perk7hirecooks;


            perk1chefItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex==0)
                    {
                        if (Game.Player.Money >= perk1price)
                        {
                            Game.Player.Money -= perk1price;
                            perk1chef = perk1chefItem.Checked;
                            if (perk1chef)
                            {
                                GTA.UI.Notification.Show("'Hire Chef' perk has been ~g~activated.");
                                saveStats();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk1chefItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk1chef = false;
                        GTA.UI.Notification.Show("'Hire Chef' perk has been ~r~deactivated.");
                        saveStats();
                    }
                };
                  perk2supplyItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 1)
                    {
                        if (Game.Player.Money >= perk2price)
                        {
                            Game.Player.Money -= perk2price;
                            perk2supplydeal = perk2supplyItem.Checked;
                            if (perk2supplydeal)
                            {
                                GTA.UI.Notification.Show("'Negotiation skills' perk has been ~g~activated.");
                                saveStats();
                                perk2supplymultiplier = 1.34f;
                                getSuppliesItem.Description = "1x supply costs ~g~$" + (Convert.ToInt32(Math.Ceiling(Convert.ToDouble(supplyPrice) / perk2supplymultiplier))).ToString();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                                //Redraw menu description
                               // ReDraw(getSuppliesItem);
                            }
                        }
                        else
                        {
                            perk2supplyItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk2supplydeal = false;
                        perk2supplymultiplier = 1;                        
                        GTA.UI.Notification.Show("'Negotiation skills' perk has been ~r~deactivated.");
                        saveStats();
                        getSuppliesItem.Description = "1x supply costs ~g~$" + supplyPrice.ToString();
                        //Redraw menu description
                        ReDraw(getSuppliesItem);
                    }
                };
                  perk3blueItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 2)
                    {
                        if (Game.Player.Money >= perk3price)
                        {
                            Game.Player.Money -= perk3price;
                            perk3bluemeth = perk3blueItem.Checked;
                            if (perk3bluemeth)
                            {
                                GTA.UI.Notification.Show("'Negotiation skills' perk has been ~g~activated.");
                                saveStats();
                                perk3bluemethmultiplier = 1.2f;
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk3blueItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk3bluemeth = false;
                        GTA.UI.Notification.Show("'Negotiation skills' perk has been ~r~deactivated.");
                        saveStats();
                    }
                };
                  perk4veryItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 3)
                    {
                        if (Game.Player.Money >= perk4price)
                        {
                            Game.Player.Money -= perk4price;
                            perk4verylarge = perk4veryItem.Checked;
                            if (perk4verylarge)
                            {
                                GTA.UI.Notification.Show("'Bigger bucket' perk has been ~g~activated.");
                                saveStats();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk4veryItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk4verylarge = false;
                        GTA.UI.Notification.Show("'Bigger bucket' perk has been ~r~deactivated.");
                        saveStats();
                    }
                };
                  perk5securityItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 4)
                    {
                        if (Game.Player.Money >= perk5price)
                        {
                            Game.Player.Money -= perk5price;
                            perk5securityintel = perk5securityItem.Checked;
                            if (perk5securityintel)
                            {
                                GTA.UI.Notification.Show("'Security intel' perk has been ~g~activated.");
                                saveStats();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk5securityItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk5securityintel = false;
                        GTA.UI.Notification.Show("'Security intel' perk has been ~r~deactivated.");
                        saveStats();
                    }
                };
                  perk6backgroundItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 5)
                    {
                        if (Game.Player.Money >= perk6price)
                        {
                            Game.Player.Money -= perk6price;
                            perk6backgroundcheck = perk6backgroundItem.Checked;
                            if (perk6backgroundcheck)
                            {
                                robberyFreq = robberyFreq_orig * 2;
                                policeFreq = policeFreq_orig * 2;
                                robberybulkFreq = robberybulkFreq_orig * 2;
                                policebulkFreq = policebulkFreq_orig * 2;
                                GTA.UI.Notification.Show("'Background check' perk has been ~g~activated.");
                                saveStats();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk6backgroundItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk6backgroundcheck = false;
                        robberyFreq = robberyFreq_orig;
                        policeFreq = policeFreq_orig;
                        robberybulkFreq = robberybulkFreq_orig;
                        policebulkFreq = policebulkFreq_orig;
                        GTA.UI.Notification.Show("'Background check' perk has been ~r~deactivated.");
                        saveStats();
                    }
                };
                  perk7hirecookItem.Activated += (sender, item) =>
                {
                    if (perkMenu.SelectedIndex == 6)
                    {
                        if (Game.Player.Money >= perk7price)
                        {
                            Game.Player.Money -= perk7price;
                            perk7hirecooks = perk7hirecookItem.Checked;
                            if (perk7hirecooks)
                            {
                                GTA.UI.Notification.Show("'Hire cooks' perk has been ~g~activated.");
                                saveStats();
                                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                            }
                        }
                        else
                        {
                            perk7hirecookItem.Checked = false;
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                            GTA.UI.Notification.Show("~r~You do not have enough money.");
                        }
                    }
                    else
                    {
                        perk7hirecooks = false;
                        GTA.UI.Notification.Show("'Hire cooks' perk has been ~r~deactivated.");

                        foreach (Ped currentped in getPerk7Peds())
                        {
                            if (currentped != null && currentped.Exists())
                            {
                                perk7ped1.Task.ReactAndFlee(Game.Player.Character);
                                perk7ped2.Task.ReactAndFlee(Game.Player.Character);
                            }
                        }

                        saveStats();
                    }
                };
            
        }

        public void cancelDealMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu cancelDealMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "Cancel current deal");
            menu.AddSubMenu(cancelDealMenu);
            _menuPool.Add(cancelDealMenu);
 
            for (int i = 0; i < 1; i++) ;

            SetBanner(cancelDealMenu);

            var cancelDealConfirm = new LemonUI.Menus.NativeItem("Confirm cancel current deal");
            cancelDealMenu.Add(cancelDealConfirm);

//Was OnItemSelect
            
                  cancelDealConfirm.Activated += (sender, item) =>
                {
                    if (OnSupply == 1 || OnDeal == 1 || OnUpgrade == 1)
                    {
                        QuitAnyCurrent();
                    }
                    else
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~You are not currently on any deal/mission.");
                    }

                };
            
        }

        public void aboutMenu(LemonUI.Menus.NativeMenu menu)
        {
            LemonUI.Menus.NativeMenu aboutMenu = new LemonUI.Menus.NativeMenu("Meth Dealing", "About");
            menu.AddSubMenu(aboutMenu);
            _menuPool.Add(aboutMenu);
            for (int i = 0; i < 1; i++) ;

            SetBanner(aboutMenu);

            var aboutThisMod = new LemonUI.Menus.NativeItem("About this mod");
            aboutMenu.Add(aboutThisMod);

            var resetSave = new LemonUI.Menus.NativeItem("Delete save file");
            var reloadSave = new LemonUI.Menus.NativeItem("Reload save file");
            var noSaves = new LemonUI.Menus.NativeItem("Save functionality disabled");
            if (saveToggle == 1)
            {
                aboutMenu.Add(reloadSave);
                aboutMenu.Add(resetSave);
            }           
            else
            {
                aboutMenu.Add(noSaves);
            }

            var updateCheckConfirm = new LemonUI.Menus.NativeItem("Check for updates");
            aboutMenu.Add(updateCheckConfirm);

//Was OnItemSelect
            
                  aboutThisMod.Activated += (sender, item) =>
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                    GTA.UI.Notification.Show("~r~Meth Dealing V" + modVersion + " ~w~was originally developed by FelixTheBlackCat. then Updated by ~g~HKH191~w~ in 2022");
                };
                  reloadSave.Activated += (sender, item) =>
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");

                    loadStats();

                    GTA.UI.Notification.Show("Save file reloaded. | ~r~"+currentGrams+"g of meth.~w~ | ~b~"+currentSupplies+" supplies.~w~ | ~g~"+upgradeCount+" upgrades completed.~w~ | + Perks");
                };
                  resetSave.Activated += (sender, item) =>
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                    GTA.UI.Notification.Show("To reset save data, delete/clear the file '~g~MethSave.dat~w~'.");
                    GTA.UI.Notification.Show("This file can be found in your main game folder with ~g~GTA5.exe~w~.");
                };
                  noSaves.Activated += (sender, item) =>
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~Save functionality disabled.~w~ Enable this from the ~g~MethDealing_Settings.ini~w~ configuration file in your scripts folder.");
                };
                  updateCheckConfirm.Activated += (sender, item) =>
                {
                    string updateVersion = checkUpdate();
                    if (updateVersion == "Failed")
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~An error occured whilst checking for updates.");
                    }
                    else if (modVersion != updateVersion)
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~Installed version: V" + modVersion + " - Latest version: V" + updateVersion);
                        GTA.UI.Notification.Show("~w~Please visit ~g~tiny.cc/gtameth~w~ to install the latest version.");
                    }
                    else
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
                        GTA.UI.Notification.Show("~g~Mod is up to date - V" + modVersion);
                    }
                };
                
        }

        public void startMenus()
        {
            _menuPool = new LemonUI.ObjectPool();
            _menuPool.Add(mainMenu);
            cookMenu(mainMenu);
            sellMenu(mainMenu);
            suppliesMenu(mainMenu);
            upgradeLabMenu(mainMenu);
            perkMenu(mainMenu);
            cancelDealMenu(mainMenu);
            aboutMenu(mainMenu);
          //  _menuPool.RefreshSelectedIndex();

            //Redraw supplies price for perk
            getSuppliesItem.Description = "1x supply costs ~g~$" + (Convert.ToInt32(Math.Ceiling(Convert.ToDouble(supplyPrice) / perk2supplymultiplier))).ToString();
          //  ReDraw(getSuppliesItem);

            SetBanner(mainMenu);
        }

        private void ReDraw(LemonUI.Menus.NativeListItem<dynamic> item)
        {
            MethodInfo privMethod = item.Panel.GetType().GetMethod("DrawCalculations", BindingFlags.NonPublic | BindingFlags.Instance);
            privMethod.Invoke(item.Panel, new object[] { });
        }

        //-----------------------

        public static string checkUpdate()
        {
            try
            {
                var url = "https://pastebin.com/raw/KwPVxJGM";
                return (new System.Net.WebClient()).DownloadString(url);
            }
            catch
            {
                //GTA.UI.Notification.Show(e.ToString());
                return "Failed";
            }

        }

        public static void ResetCookingCooldown()
        {
            if (Meth.CookingCooldown == 1)
            {
                Meth.TimerCounter += 250;
                if (Meth.TimerCounter >= Meth.TimerTarget)
                {
                    Meth.CookingCooldown = 0;
                }
            }
        }
        public static ScriptSettings Config;
        public static void saveStats()
        {
            if (saveToggle == 1)
            {
                try
                {
                    Config = ScriptSettings.Load(savepath);
                    Config.SetValue<bool>("Perks", "perk1chef", perk1chef);
                    Config.SetValue<bool>("Perks", "perk2supplydeal", perk2supplydeal);
                    Config.SetValue<bool>("Perks", "perk3bluemeth", perk3bluemeth);
                    Config.SetValue<bool>("Perks", "perk4verylarge", perk4verylarge);
                    Config.SetValue<bool>("Perks", "perk5securityintel", perk5securityintel);
                    Config.SetValue<bool>("Perks", "perk6backgroundcheck", perk6backgroundcheck);
                    Config.SetValue<bool>("Perks", "perk7hirecooks", perk7hirecooks);
                    Config.Save();
                    
                    
                    
                }
                catch
                {
                    GTA.UI.Notification.Show("~r~Error updating save file.");
                    GTA.UI.Notification.Show("~b~Try creating a file called MethDealing in your scripts folder, this may fix error.");
                }
            }
        }

        public static void loadStats()
        {
            try
            {
                Config = ScriptSettings.Load(savepath);
                perk1chef= Config.GetValue<bool>("Perks", "perk1chef", perk1chef);
                perk2supplydeal= Config.GetValue<bool>("Perks", "perk2supplydeal", perk2supplydeal);
                perk3bluemeth=Config.GetValue<bool>("Perks", "perk3bluemeth", perk3bluemeth);
                perk4verylarge=Config.GetValue<bool>("Perks", "perk4verylarge", perk4verylarge);
                perk5securityintel= Config.GetValue<bool>("Perks", "perk5securityintel", perk5securityintel);
                perk6backgroundcheck= Config.GetValue<bool>("Perks", "perk6backgroundcheck", perk6backgroundcheck);
                perk7hirecooks= Config.GetValue<bool>("Perks", "perk7hirecooks", perk7hirecooks);
         
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Error reloading save file, creating new with current stats");
                saveStats();
            }            
        }

        public static void autoBatchTimer()
        {
            if (Meth.largeBatchStart == 1 || Meth.smallBatchStart == 1 || Meth.large2BatchStart == 1)
            {
                float pitch = Function.Call<float>(Hash.GET_GAMEPLAY_CAM_RELATIVE_PITCH);
                float heading = Function.Call<float>(Hash.GET_GAMEPLAY_CAM_RELATIVE_HEADING);
                Vector3 camRotation = new Vector3(Game.Player.Character.Rotation.X + pitch, 0, Game.Player.Character.Rotation.Z + heading);
                var tmpSF = new Scaleform("PLAYER_NAME_01");
                double percent = Math.Round(Convert.ToDouble(TimerCounterAutoBatch / TimerTarget), 2) * 100;
                if (Meth.largeBatchStart == 1)
                {
                    Meth.TimerCounterAutoBatch += 40;
                    tmpSF.CallFunction("SET_PLAYER_NAME", "Cooking large batch - ~g~" + percent.ToString() + "%");

                    if (Meth.TimerCounterAutoBatch >= Meth.TimerTarget)
                    {
                        Meth.largeBatchStart = 0;
                        autoBatchFinished("large");
                    }
                }
                if (Meth.large2BatchStart == 1)
                {
                    Meth.TimerCounterAutoBatch += 9;
                    tmpSF.CallFunction("SET_PLAYER_NAME", "Cooking very large batch - ~g~" + percent.ToString() + "%");

                    if (Meth.TimerCounterAutoBatch >= Meth.TimerTarget)
                    {
                        Meth.large2BatchStart = 0;
                        autoBatchFinished("vlarge");
                    }
                }
                if (Meth.smallBatchStart == 1)
                {
                    Meth.TimerCounterAutoBatch += 143;
                    tmpSF.CallFunction("SET_PLAYER_NAME", "Cooking small batch - ~g~" + percent.ToString() + "%");

                    if (Meth.TimerCounterAutoBatch >= Meth.TimerTarget)
                    {
                        Meth.smallBatchStart = 0;
                        autoBatchFinished("small");
                    }
                }
                tmpSF.Render3D(new Vector3(1390.65f, 3605.19f, 39.85f), camRotation, new Vector3(6, 3, 1));
            }            
        }

        public static Vector3 GetPlayerLookingDirection(Vector3 camPosition)
        {
            if (World.RenderingCamera.IsActive)
            {
                GTA.UI.Notification.Show("render camera acticve");
                camPosition = World.RenderingCamera.Position;
                return World.RenderingCamera.Direction;
            }
            else
            {
                float pitch = Function.Call<float>(Hash.GET_GAMEPLAY_CAM_RELATIVE_PITCH);
                float heading = Function.Call<float>(Hash.GET_GAMEPLAY_CAM_RELATIVE_HEADING);

                camPosition = Function.Call<Vector3>(Hash.GET_GAMEPLAY_CAM_COORD);
                return camPosition;
                //return (Game.Player.Character.Rotation + new Rotator(pitch, 0, heading)).ToVector().ToNormalized();
            }
        }

        public static void killerhashTimer()
        {
            if (killerHash != 0)
            {
                Meth.hashTimerCounter += 1;
                if (Meth.hashTimerCounter >= Meth.hashTimerTarget)
                {
                    killerHash = 0;
                }
            }
        }

        //Scene create-----------
        public static void DoSupplier()
        {
            try
            {
                Meth.OnSupply = 1;
                Random random = new Random();
                Meth.Supplier = random.Next(1, 3);
                if (Meth.Supplier == 1)
                {
                    Vector3 rot = new GTA.Math.Vector3(1.249929f, -2.750007f, -2.249996f);
                    Model model = RequestModel(247892203);
                    model.Request(10000);
                    supply1crate = GTA.World.CreateProp(model, supply1location, rot, false, false);
                    supply1crate.Position = supply1location;
                    supply1crate.LodDistance = 3000;
                    supply1crate.IsPositionFrozen = true;

                    Meth.supply1vehicle1 = GTA.World.CreateVehicle(RequestModel(1753414259), new GTA.Math.Vector3(30.50795f, 3731.308f, 39.03741f), -144.6229f);
                    Meth.supply1vehicle2 = GTA.World.CreateVehicle(RequestModel(683047626), new GTA.Math.Vector3(37.22862f, 3714.485f, 39.83883f), -160.9929f);
                    Meth.supply1vehicle3 = GTA.World.CreateVehicle(RequestModel(-304802106), new GTA.Math.Vector3(19.1619f, 3706.148f, 39.41411f), -135.2817f);
                    Meth.supply1ped1 = GTA.World.CreatePed(RequestModel(228715206), new GTA.Math.Vector3(34.80548f, 3716.895f, 39.50547f), -5.57376f);
                    Meth.supply1ped2 = GTA.World.CreatePed(RequestModel(1768677545), new GTA.Math.Vector3(31.31724f, 3732.773f, 40.62968f), 162.6417f);
                    Meth.supply1ped3 = GTA.World.CreatePed(RequestModel(-48477765), new GTA.Math.Vector3(37.67926f, 3717.78f, 39.57497f), 61.91966f);
                    Meth.supply1ped4 = GTA.World.CreatePed(RequestModel(62440720), new GTA.Math.Vector3(22.83964f, 3715.866f, 39.78373f), -124.4291f);
                    Meth.supply1ped5 = GTA.World.CreatePed(RequestModel(-613248456), new GTA.Math.Vector3(20.11632f, 3707.486f, 39.93513f), -65.95496f);

                    Meth.supply1ped1.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.supply1ped1.Position);
                    Meth.supply1ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.supply1ped2.Position);
                    Meth.supply1ped3.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.supply1ped3.Position);
                    Meth.supply1ped4.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.supply1ped4.Position);

                    Meth.supply1ped1.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.supply1ped2.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.supply1ped3.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.supply1ped4.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);

                    Meth.supply1crate.AddBlip();
                    supply1crate.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    supply1crate.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply1crate.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 1;
                }
                else if (Meth.Supplier == 2)
                {
                    Vector3 rot = new GTA.Math.Vector3(7.045523f, 2.118938f, 27.39322f);
                    Model model = RequestModel(247892203);
                    model.Request(10000);
                    supply2crate = GTA.World.CreateProp(model, supply2location, rot, false, false);
                    supply2crate.Position = supply2location;
                    supply2crate.LodDistance = 3000;
                    supply2crate.IsPositionFrozen = true;

                    Meth.supply2vehicle1 = GTA.World.CreateVehicle(RequestModel(-589178377), new GTA.Math.Vector3(2332.494f, 3256.57f, 46.09455f), -62.81354f);

                    Meth.supply2ped1 = GTA.World.CreatePed(RequestModel(-1709285806), new GTA.Math.Vector3(2329.463f, 3254.556f, 47.08295f), 2.973228f);
                    Meth.supply2ped2 = GTA.World.CreatePed(RequestModel(1822107721), new GTA.Math.Vector3(2330.534f, 3254.982f, 46.98711f), 50.06031f);

                    Meth.supply2ped1.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.supply2ped2.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);

                    Meth.supply2crate.AddBlip();
                    supply2crate.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    supply2crate.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply2crate.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 2;
                }
                
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Script error - please cancel the deal and try again");
                QuitAnyCurrent();
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
            }
        }

        public static void DoSupplierLarge()
        {
            try
            {
                Meth.OnSupply = 1;
                Random random = new Random();
                Meth.Supplier = random.Next(100, 105);
                if (Meth.Supplier == 100)
                {
                    supply100_p1 = 1;
                    Meth.supply100vehicle1 = GTA.World.CreateVehicle(RequestModel(-1743316013), new GTA.Math.Vector3(1737.691f, 3299.904f, 41.0368f), -163.7552f); //Main burrito
                    Meth.supply100vehicle2 = GTA.World.CreateVehicle(RequestModel(470404958), new GTA.Math.Vector3(1735.324f, 3313.819f, 41.13637f), 46.3611f);
                    Meth.supply100vehicle3 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(1767.907f, 3308.549f, 43.02583f), -102.0172f);
                    Meth.supply100vehicle4 = GTA.World.CreateVehicle(new Model(569305213), new GTA.Math.Vector3(1774.955f, 3305.573f, 41.30701f), -129.401f);
                    Meth.supply100vehicle5 = GTA.World.CreateVehicle(new Model(-120287622), new GTA.Math.Vector3(1716.777f, 3320.531f, 40.70575f), 30.61937f);
                    Meth.supply100vehicle6 = GTA.World.CreateVehicle(new Model(410882957), new GTA.Math.Vector3(1726.479f, 3304.167f, 40.96267f), -4.331663f);
                    Meth.supply100ped1 = GTA.World.CreatePed(new Model(-236444766), new GTA.Math.Vector3(1731.161f, 3308.914f, 41.22349f), -164.9982f); //Arm ped
                    Meth.supply100ped2 = GTA.World.CreatePed(new Model(-984709238), new GTA.Math.Vector3(1778.127f, 3308.93f, 41.26607f), 92.54225f);
                    Meth.supply100ped3 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(1776.895f, 3308.578f, 41.23178f), -69.25532f);
                    Meth.supply100ped4 = GTA.World.CreatePed(new Model(653210662), new GTA.Math.Vector3(1736.572f, 3310.279f, 41.22349f), 163.8191f);
                    Meth.supply100ped5 = GTA.World.CreatePed(new Model(832784782), new GTA.Math.Vector3(1725.642f, 3295.243f, 41.22349f), -30.87549f);
                    Meth.supply100ped6 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(1726.019f, 3295.729f, 41.22349f), 128.3713f);
                    Meth.supply100ped7 = GTA.World.CreatePed(new Model(1329576454), new GTA.Math.Vector3(1730.227f, 3309.128f, 41.22349f), -151.9981f);
                    Meth.supply100ped8 = GTA.World.CreatePed(new Model(2119136831), new GTA.Math.Vector3(1777.576f, 3309.768f, 41.24263f), 154.998f);
                    Meth.supply100ped9 = GTA.World.CreatePed(new Model(275618457), new GTA.Math.Vector3(1731.974f, 3309.317f, 41.22349f), 175.4975f);
                    Meth.supply100ped10 = GTA.World.CreatePed(new Model(-424905564), new GTA.Math.Vector3(1727.745f, 3303.862f, 41.22349f), -85.69844f);
                    Meth.supply100ped1.Weapons.Give(WeaponHash.KnuckleDuster, 100, true, false);
                    Meth.supply100ped2.Weapons.Give(WeaponHash.BattleAxe, 100, true, false);
                    Meth.supply100ped3.Weapons.Give(WeaponHash.SawnOffShotgun, 100, true, false);
                    Meth.supply100ped4.Weapons.Give(WeaponHash.AssaultSMG, 100, true, false);
                    Meth.supply100ped5.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.supply100ped6.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.supply100ped7.Weapons.Give(WeaponHash.AssaultRifle, 100, true, false);
                    Meth.supply100ped8.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.supply100ped9.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.supply100ped1.AddBlip();
                    supply100ped1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    supply100ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply100ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 100;
                }
                if (Meth.Supplier == 101)
                {
                    supply101_p1 = 1;
                    Meth.supply101vehicle1 = GTA.World.CreateVehicle(new Model(1353720154), new GTA.Math.Vector3(916.9577f, 3227.12f, 37.77361f), -84.85264f); //Main flatbed
                    Meth.supply101vehicle2 = GTA.World.CreateVehicle(new Model(-1050465301), new GTA.Math.Vector3(914.8985f, 3212.09f, 38.23495f), -33.28543f);
                    Meth.supply101vehicle3 = GTA.World.CreateVehicle(new Model(-1122289213), new GTA.Math.Vector3(879.5189f, 3209.515f, 38.36486f), -34.30712f);
                    Meth.supply101vehicle4 = GTA.World.CreateVehicle(new Model(833469436), new GTA.Math.Vector3(929.3218f, 3217.77f, 38.33878f), 95.20866f);

                    Vector3 rot = new GTA.Math.Vector3(1388.729f, 3613.192f, 42.63286f);
                    Model model = new Model(90805875);
                    model.Request(10000);
                    supply101crate1 = GTA.World.CreateProp(model, supply1location, rot, false, false);
                    supply101crate1.SetNoCollision(GTA.Game.Player.Character, true);
                    supply101crate1.Position = Game.Player.Character.Position;
                    AttachEntityToEntity(supply101crate1, supply101vehicle1, supply101vehicle1.GetBoneIndex("bodyshell"), new Vector3(0f, 0f, 1f), new Vector3(0f, 0f, 0f), false, false, false, 2, true);

                    rot = new GTA.Math.Vector3(1388.729f, 3613.192f, 42.63286f);
                    model = new Model(90805875);
                    model.Request(10000);
                    supply101crate2 = GTA.World.CreateProp(model, supply1location, rot, false, false);
                    supply101crate2.SetNoCollision(GTA.Game.Player.Character, true);
                    supply101crate2.Position = Game.Player.Character.Position;
                    AttachEntityToEntity(supply101crate2, supply101vehicle1, supply101vehicle1.GetBoneIndex("bodyshell"), new Vector3(0f, -1.56f, 0.98f), new Vector3(0f, 0f, 2.5f), false, false, false, 2, true);

                    rot = new GTA.Math.Vector3(1388.729f, 3613.192f, 42.63286f);
                    model = new Model(90805875);
                    model.Request(10000);
                    supply101crate3 = GTA.World.CreateProp(model, supply1location, rot, false, false);
                    supply101crate3.SetNoCollision(GTA.Game.Player.Character, true);
                    supply101crate3.Position = Game.Player.Character.Position;
                    AttachEntityToEntity(supply101crate3, supply101vehicle1, supply101vehicle1.GetBoneIndex("bodyshell"), new Vector3(0f, -3.06f, 0.98f), new Vector3(0f, 0f, 0f), false, false, false, 2, true);


                    Meth.supply101ped1 = GTA.World.CreatePed(new Model(-245247470), new GTA.Math.Vector3(915.8012f, 3216.68f, 37.80977f), 21.00023f); //Boss ped
                    Meth.supply101ped2 = GTA.World.CreatePed(new Model(1142162924), new GTA.Math.Vector3(878.3032f, 3210.423f, 38.94556f), 37.99935f);
                    Meth.supply101ped3 = GTA.World.CreatePed(new Model(-1105135100), new GTA.Math.Vector3(914.9085f, 3215.062f, 37.92984f), 49.45645f);
                    Meth.supply101ped4 = GTA.World.CreatePed(new Model(32417469), new GTA.Math.Vector3(917.3062f, 3216.241f, 37.97442f), 42.12531f);
                    Meth.supply101ped5 = GTA.World.CreatePed(new Model(1161072059), new GTA.Math.Vector3(928.9919f, 3219.239f, 38.72077f), 1.991193f);
                    Meth.supply101ped6 = GTA.World.CreatePed(new Model(-9308122), new GTA.Math.Vector3(901.8941f, 3214.551f, 39.04514f), 6.779407f);

                    Meth.supply101ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.supply101ped2.Position);
                    Meth.supply101ped5.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.supply101ped5.Position);

                    Meth.supply101ped1.Weapons.Give(WeaponHash.Knife, 100, true, false);
                    Meth.supply101ped2.Weapons.Give(WeaponHash.AssaultRifle, 100, true, false);
                    Meth.supply101ped3.Weapons.Give(WeaponHash.SawnOffShotgun, 100, true, false);
                    Meth.supply101ped4.Weapons.Give(WeaponHash.AssaultSMG, 100, true, false);
                    Meth.supply101ped5.Weapons.Give(WeaponHash.AssaultRifle, 100, true, false);
                    Meth.supply101ped6.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);

                    Meth.supply101ped1.AddBlip();
                    supply101ped1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    supply101ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply101ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 101;
                }
                if (Meth.Supplier == 102)
                {
                    supply102_part = 1;

                    //Truck random
                    int truckrandom = random.Next(1, 8);
                    if (truckrandom==1)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(2487.655f, 4122.348f, 38.34645f), 154.6222f);
                    }
                    else if (truckrandom == 2)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(896.7539f, 3649.353f, 33.01156f), 91.50149f);
                    }
                    else if (truckrandom == 3)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(461.9666f, 3548.505f, 33.47028f), 74.92836f);
                    }
                    else if (truckrandom == 4)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(393.7837f, 3589.432f, 33.52397f), -98.03756f);
                    }
                    else if (truckrandom == 5)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(432.5303f, 3518.944f, 34.00178f), 101.7411f);
                    }
                    else if (truckrandom == 6)
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(1892.821f, 3704.923f, 33.1071f), 122.041f);
                    }
                    else
                    {
                        Meth.supply102vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(1966.596f, 3853.509f, 32.23496f), -148.5567f);
                    }

                    Meth.supply102vehicle1.AddBlip();
                    supply102vehicle1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    supply102vehicle1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply102vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 102;
                }
                if (Meth.Supplier == 103)
                {
                    supply103_part = 1;

                    //Truck random
                    int trailerrandom = random.Next(1, 8);
                    if (trailerrandom == 1)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(1767.442f, 3307.859f, 43.15251f), -136.4872f);
                    }
                    else if (trailerrandom == 2)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-2058878099), new GTA.Math.Vector3(1986.283f, 3033.763f, 49.30854f), 57.2417f);
                    }
                    else if (trailerrandom == 3)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(2043.445f, 3179.405f, 46.97549f), 150.7142f);
                    }
                    else if (trailerrandom == 4)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-2058878099), new GTA.Math.Vector3(1964.73f, 3773.939f, 34.44862f), 30.64485f);
                    }
                    else if (trailerrandom == 5)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(2531.43f, 4212.072f, 42.07367f), -119.55f);
                    }
                    else if (trailerrandom == 6)
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-2058878099), new GTA.Math.Vector3(1026.152f, 2657.845f, 41.80072f), 0.6971049f);
                    }
                    else
                    {
                        Meth.supply103vehicle1 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(2654.815f, 3269.256f, 57.22864f), 155.5547f);
                    }

                    supply103vehicle2 = GTA.World.CreateVehicle(new Model(1518533038), new GTA.Math.Vector3(1435.672f, 3614.65f, 35.1493f), -175.5079f);
                    supply103vehicle3 = GTA.World.CreateVehicle(new Model(-2137348917), new GTA.Math.Vector3(1347.635f, 3604.135f, 34.96044f), -161.5265f);

                    Meth.supply103vehicle2.AddBlip();
                    supply103vehicle2.AttachedBlip.Sprite = BlipSprite.Truck;
                    supply103vehicle2.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply103vehicle3.AddBlip();
                    supply103vehicle3.AttachedBlip.Sprite = BlipSprite.Truck;
                    supply103vehicle3.AttachedBlip.Color = BlipColor.Blue;

                    Meth.supply103vehicle1.AddBlip();
                    supply103vehicle1.AttachedBlip.Sprite = BlipSprite.Trailer;
                    supply103vehicle1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply103vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 103;

                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 6);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "That supply deal has been sorted. Head to the blip to pick up a trailer containing the goods.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Find a truck cab and head to the blip, the supplies are waiting for you in a trailer.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "There's a trailer waiting with ~b~" + currentSupplyDeal.ToString() + "x ~w~supplies at the blip. Find a truck cab.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are waiting at the blip. Bring a truck cab.";
                    }
                    else if (chooser == 5)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are in a trailer waiting to be picked up.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                }
                if (Meth.Supplier == 104)
                {
                    //Heli random
                    int helirandom = random.Next(1, 8);
                    if (helirandom == 1)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(1732.262f, 3242.769f, 41.48026f), 75.67314f);
                    }
                    else if (helirandom == 2)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(1753.671f, 3287.452f, 41.21537f), -103.8992f);
                    }
                    else if (helirandom == 3)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2406.913f, 3105.336f, 48.27777f), 21.42589f);
                    }
                    else if (helirandom == 4)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2377.794f, 3073.108f, 48.25303f), 35.36357f);
                    }
                    else if (helirandom == 5)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2476f, 3421.79f, 50.01036f), 53.81745f);
                    }
                    else if (helirandom == 6)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2666.968f, 3521.062f, 52.75391f), -88.243f);
                    }
                    else if (helirandom == 7)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2353.328f, 3163.355f, 48.1737f), 142.9971f);
                    }
                    else if (helirandom == 8)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2167.511f, 3509.406f, 45.54001f), 35.77105f);
                    }
                    else if (helirandom == 9)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2138.194f, 4817.966f, 41.30239f), 61.83923f);
                    }
                    else if (helirandom == 10)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(2515.929f, 4971.677f, 44.66019f), 10.85086f);
                    }
                    else if (helirandom == 11)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(715.3496f, 4173.084f, 40.80654f), -115.5262f);
                    }
                    else if (helirandom == 12)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(354.1948f, 4446.923f, 62.96617f), -145.588f);
                    }
                    else if (helirandom == 13)
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(-1910.104f, 2051.097f, 140.8349f), -168.7388f);
                    }
                    else
                    {
                        Meth.supply104vehicle1 = GTA.World.CreateVehicle(new Model(-1660661558), new GTA.Math.Vector3(-2626.112f, 3445.36f, 15.40589f), 13.93891f);
                    }

                    //Crates
                    Vector3 rot = new GTA.Math.Vector3(1388.729f, 3613.192f, 42.63286f);
                    Model model = new Model(-230239317);
                    model.Request(10000);
                    supply104crate1 = GTA.World.CreateProp(model, new Vector3(supply104vehicle1.Position.X, supply104vehicle1.Position.Y, supply104vehicle1.Position.Z+8), rot, false, false);
                    supply104crate1.SetNoCollision(GTA.Game.Player.Character, true);
                    supply104crate1.SetNoCollision(supply104vehicle1, true);
                    supply104crate1.Position = Game.Player.Character.Position;
                    AttachEntityToEntity(supply104crate1, supply104vehicle1, supply104vehicle1.GetBoneIndex("bodyshell"), new Vector3(0f, 0.3f, 0.253f), new Vector3(0f, 0f, 0f), false, false, false, 2, true);

                    Meth.supply104vehicle1.AddBlip();
                    supply104vehicle1.AttachedBlip.Sprite = BlipSprite.Helicopter;
                    supply104vehicle1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.supply104vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastSupplier = 104;
                    supply104_part = 1;


                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 6);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Locate the chopper they've sent out. Should be waiting somewhere in Blaine County.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "The supplier has left a heli nearby with the crates. Locate it and fly it back to the lab.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "The supplier sent out a heli? Go find it and try land it in the lab car park. Don't crash..!";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are loaded in a heli waiting for you.";
                    }
                    else if (chooser == 5)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~ supllies are in a heli waiting to be flown back to the lab. Check your GPS.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                }

                if (Supplier != 103 && Supplier != 104)
                {
                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 6);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Sorted the bulk supply deal for you. Head to the blip.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Pick up the supply van waiting for you at the blip.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Head to the blip to pick up ~b~" + currentSupplyDeal.ToString() + "x ~w~supplies.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are in a van at the blip.";
                    }
                    else if (chooser == 5)
                    {
                        msg2do = "~b~" + currentSupplyDeal.ToString() + "x ~w~supplies are awaiting transport from the pick up location.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                }
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Script error - please cancel the deal and try again");
                QuitAnyCurrent();
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
            }
        }

        public static void DoCustomer()
        {
            try
            {
                Meth.OnDeal = 1;
                WasBeingRobbed = 0;
                WasBeingPoliceSetup = 0;
                Random random = new Random();
                Meth.Customer = random.Next(1, 15);

                if (previousCustomers.Count > 13)
                {
                    previousCustomers.Clear();
                }

                while (previousCustomers.Contains(Customer) == true)
                {
                    Meth.Customer = random.Next(1, 15);
                }

                if (Meth.Customer == 1)
                {
                    Meth.deal1vehicle1 = World.CreateVehicle(new Model(1069929536), new Vector3(903.9921f, 3614.968f, 32.58949f), 158.9581f);
                    Meth.deal1ped1 = World.CreatePed(new Model(1001210244), new Vector3(905.2158f, 3614.332f, 32.81895f), -100.99f);
                    Meth.deal1ped2 = World.CreatePed(new Model(1768677545), new Vector3(905.5829f, 3614.969f, 32.81862f), -122.5152f);
                    Meth.deal1ped3 = World.CreatePed(new Model(-1806291497), new Vector3(894.18f, 3599.565f, 32.81421f), 136.3854f);
                    Meth.deal1ped4 = World.CreatePed(new Model(846439045), new Vector3(893.1466f, 3598.943f, 32.81421f), -75.9983f);
                    Meth.deal1ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.deal1ped2.Position);
                    Meth.deal1ped3.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal1ped3.Position);
                    Meth.deal1ped4.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.deal1ped4.Position);
                    Meth.deal1ped1.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.deal1ped2.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.deal1ped3.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.deal1ped4.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.deal1ped1.AddBlip();
                    deal1ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal1ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal1ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 1;
                }
                if (Meth.Customer == 2)
                {
                    Meth.deal2vehicle1 = World.CreateVehicle(new Model(-682211828), new Vector3(2362.594f, 3117.407f, 47.57828f), -27.40716f);
                    Meth.deal2ped1 = World.CreatePed(new Model(32417469), new Vector3(2363.88f, 3119.749f, 48.20966f), -54.30811f);
                    Meth.deal2ped2 = World.CreatePed(new Model(810804565), new Vector3(2363.894f, 3121.085f, 48.20894f), -123.3657f);
                    Meth.deal2ped1.Weapons.Give(WeaponHash.Machete, 100, true, false);
                    Meth.deal2ped2.Weapons.Give(WeaponHash.StunGun, 100, true, false);
                    Meth.deal2ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.deal2ped2.Position);
                    Meth.deal2ped1.AddBlip();
                    deal2ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal2ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal2ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 2;
                }
                if (Meth.Customer == 3)
                {
                    Meth.deal3vehicle1 = World.CreateVehicle(new Model(-2045594037), new Vector3(2875.308f, 3688.122f, 48.22939f), -102.8129f);
                    Meth.deal3ped1 = World.CreatePed(new Model(-106498753), new Vector3(2878.413f, 3686.557f, 48.20292f), -50.73355f);
                    Meth.deal3ped2 = World.CreatePed(new Model(-578715987), new Vector3(2879.039f, 3686.151f, 48.17934f), -17.03479f);
                    Meth.deal3ped1.Weapons.Give(WeaponHash.SawnOffShotgun, 100, true, false);
                    Meth.deal3ped2.Weapons.Give(WeaponHash.DoubleBarrelShotgun, 100, true, false);
                    Meth.deal3ped2.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal3ped2.Position);
                    Meth.deal3ped1.AddBlip();
                    deal3ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal3ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal3ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 3;
                }
                if (Meth.Customer == 4)
                {
                    Meth.deal4vehicle1 = World.CreateVehicle(new Model(-1311240698), new Vector3(1975.398f, 5168.382f, 47.4132f), 125.8284f);
                    Meth.deal4ped1 = World.CreatePed(new Model(-1806291497), new Vector3(1964.085f, 5172.845f, 47.80671f), 169.6814f);
                    Meth.deal4ped2 = World.CreatePed(new Model(-261389155), new Vector3(1970.798f, 5169.874f, 47.6391f), -46.46468f);
                    Meth.deal4ped3 = World.CreatePed(new Model(-1332260293), new Vector3(1964.81f, 5172.308f, 47.76441f), 146.9773f);
                    Meth.deal4ped1.Weapons.Give(WeaponHash.Knife, 100, true, false);
                    Meth.deal4ped2.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.deal4ped3.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.deal4ped2.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal4ped2.Position);
                    Meth.deal4ped3.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.deal4ped3.Position);
                    Meth.deal4ped1.AddBlip();
                    deal4ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal4ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal4ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 4;
                }
                if (Meth.Customer == 5)
                {
                    Meth.deal5vehicle1 = World.CreateVehicle(new Model(-1453280962), new Vector3(99.58822f, 6848.579f, 15.40964f), -28.20744f);
                    Meth.deal5ped1 = World.CreatePed(new Model(-1313761614), new Vector3(100.7299f, 6847.384f, 16.04326f), -50.46243f);
                    Meth.deal5ped1.Weapons.Give(WeaponHash.Wrench, 100, true, false);
                    Meth.deal5ped1.AddBlip();
                    deal5ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal5ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal5ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 5;
                }
                if (Meth.Customer == 6)
                {
                    Meth.deal6ped1 = World.CreatePed(new Model(1787764635), new Vector3(119.4116f, -1198.594f, 29.29514f), 108.7571f);
                    Meth.deal6ped2 = World.CreatePed(new Model(1404403376), new Vector3(119.2179f, -1199.78f, 29.29514f), 61.99771f);
                    Meth.deal6ped2.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.deal6ped2.Position);
                    Meth.deal6ped1.Weapons.Give(WeaponHash.AssaultSMG, 100, true, false);
                    Meth.deal6ped2.Weapons.Give(WeaponHash.BattleAxe, 100, true, false);
                    Meth.deal6ped1.AddBlip();
                    deal6ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal6ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal6ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 6;
                }
                if (Meth.Customer == 7)
                {
                    Meth.deal7ped1 = World.CreatePed(new Model(835315305), new Vector3(-3193.423f, 1231.214f, 10.04833f), -72.65874f);
                    Meth.deal7ped1.Weapons.Give(WeaponHash.SawnOffShotgun, 100, true, false);
                    Meth.deal7ped1.AddBlip();
                    deal7ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal7ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal7ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 7;
                }
                if (Meth.Customer == 8)
                {
                    Meth.deal8vehicle1 = World.CreateVehicle(new Model(-1743316013), new Vector3(1208.471f, 2638.869f, 37.62344f), -69.56764f);
                    Meth.deal8ped1 = World.CreatePed(new Model(1768677545), new Vector3(1213.307f, 2643.646f, 37.80995f), 58.5533f);
                    Meth.deal8ped2 = World.CreatePed(new Model(348382215), new Vector3(1212.701f, 2643.277f, 37.80995f), 32.53157f);
                    Meth.deal8ped3 = World.CreatePed(new Model(-429715051), new Vector3(1206.976f, 2636.807f, 37.80995f), 160.6528f);
                    Meth.deal8ped1.Weapons.Give(WeaponHash.Pistol, 100, true, false);
                    Meth.deal8ped3.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.deal8ped2.Task.StartScenario("WORLD_HUMAN_STAND_IMPATIENT", Meth.deal8ped2.Position);
                    Meth.deal8ped3.Task.StartScenario("WORLD_HUMAN_GUARD_STAND", Meth.deal8ped3.Position);
                    Meth.deal8ped1.AddBlip();
                    deal8ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal8ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal8ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 8;
                }
                if (Meth.Customer == 9)
                {
                    Meth.deal8vehicle1 = World.CreateVehicle(new Model(-1743316013), new Vector3(1208.471f, 2638.869f, 37.62344f), -69.56764f);
                    Meth.deal9ped1 = World.CreatePed(new Model(653210662), new Vector3(1684.572f, 3288.351f, 41.14653f), 166.6336f);
                    Meth.deal9ped2 = World.CreatePed(new Model(-1561829034), new Vector3(1685.098f, 3287.572f, 41.14653f), 122.9997f);
                    Meth.deal9ped1.Weapons.Give(WeaponHash.SNSPistol, 100, true, false);
                    Meth.deal9ped2.Weapons.Give(WeaponHash.Pistol50, 100, true, false);
                    Meth.deal9ped1.AddBlip();
                    deal9ped1.AttachedBlip.Color = BlipColor.Blue;
                    deal9ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    Meth.deal9ped1.AttachedBlip.ShowRoute = true;
                    Meth.LastCustomer = 9;
                }
                if (Meth.Customer == 10)
                {
                    Meth.deal10vehicle1 = World.CreateVehicle(new Model(-1323100960), new Vector3(2159.83f, 2117.29f, 126.2178f), 4.071282f);
                    Meth.deal10ped1 = World.CreatePed(new Model(-1105179493), new Vector3(2162.119f, 2117.68f, 125.9504f), -52.66581f);
                    Meth.deal10ped2 = World.CreatePed(new Model(-2039072303), new Vector3(2161.88f, 2118.494f, 125.9314f), -88.54652f);
                    Meth.deal10ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.deal10ped2.Position);
                    Meth.deal10ped1.AddBlip();
                    deal10ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal10ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal10ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal10ped1.Weapons.Give(WeaponHash.SNSPistol, 100, true, false);
                    Meth.deal10ped2.Weapons.Give(WeaponHash.Knife, 100, true, false);
                    Meth.LastCustomer = 10;
                }
                if (Meth.Customer == 11)
                {
                    Meth.deal11vehicle1 = World.CreateVehicle(new Model(-1297672541), new Vector3(2591.913f, 3160.892f, 50.05851f), -47.32346f);
                    Meth.deal11vehicle2 = World.CreateVehicle(new Model(2006918058), new Vector3(2576.226f, 3177.663f, 50.83627f), -71.95502f);
                    Meth.deal11vehicle3 = World.CreateVehicle(new Model(2006667053), new Vector3(2596.835f, 3183.224f, 51.48439f), 91.72227f);
                    Meth.deal11vehicle4 = World.CreateVehicle(new Model(1770332643), new Vector3(2597.577f, 3161.19f, 50.58514f), 22.94889f);
                    Meth.deal11vehicle5 = World.CreateVehicle(new Model(1739845664), new Vector3(2601.628f, 3177.119f, 51.17874f), -146.8833f);
                    Meth.deal11vehicle6 = World.CreateVehicle(new Model(1177543287), new Vector3(2586.546f, 3173.46f, 50.66679f), -158.6337f);
                    Meth.deal11vehicle7 = World.CreateVehicle(new Model(1126868326), new Vector3(2593.368f, 3167.821f, 50.62262f), 95.59938f);
                    Meth.deal11ped1 = World.CreatePed(new Model(51789996), new Vector3(2594.258f, 3170.011f, 51.03237f), 5.594477f);
                    Meth.deal11ped2 = World.CreatePed(new Model(-9308122), new Vector3(2593.87f, 3170.533f, 51.03777f), -22.03105f);
                    Meth.deal11ped3 = World.CreatePed(new Model(-48477765), new Vector3(2578.827f, 3178.599f, 51.2319f), -47.13006f);
                    Meth.deal11ped4 = World.CreatePed(new Model(-96953009), new Vector3(2580.009f, 3154.376f, 50.63525f), -158.4494f);
                    Meth.deal11ped5 = World.CreatePed(new Model(-198252413), new Vector3(2580.321f, 3153.514f, 50.60846f), 22.99918f);
                    Meth.deal11ped6 = World.CreatePed(new Model(-1492432238), new Vector3(2592.883f, 3160.074f, 50.82481f), -121.5816f);
                    Meth.deal11ped7 = World.CreatePed(new Model(-1561829034), new Vector3(2593.797f, 3159.549f, 50.82723f), 68.9992f);
                    Meth.deal11ped2.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal11ped2.Position);
                    Meth.deal11ped3.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.deal11ped3.Position);
                    Meth.deal11ped4.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.deal11ped4.Position);
                    Meth.deal11ped5.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal11ped5.Position);
                    Meth.deal11ped6.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.deal11ped6.Position);
                    Meth.deal11ped7.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal11ped7.Position);
                    Meth.deal11ped1.AddBlip();
                    deal11ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal11ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal11ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal11ped1.Weapons.Give(WeaponHash.SNSPistol, 100, true, false);
                    Meth.deal11ped2.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.deal11ped3.Weapons.Give(WeaponHash.Bat, 100, true, false);
                    Meth.deal11ped4.Weapons.Give(WeaponHash.HeavyPistol, 100, true, false);
                    Meth.deal11ped5.Weapons.Give(WeaponHash.SpecialCarbine, 100, true, false);
                    Meth.deal11ped6.Weapons.Give(WeaponHash.SawnOffShotgun, 100, true, false);
                    Meth.LastCustomer = 11;
                }
                if (Meth.Customer == 12)
                {
                    Meth.deal12vehicle1 = World.CreateVehicle(new Model(296357396), new Vector3(-387.5374f, 3960.952f, 58.28973f), -71.94999f);
                    Meth.deal12vehicle2 = World.CreateVehicle(new Model(296357396), new Vector3(-387.1665f, 3972.754f, 55.57044f), -62.34592f);
                    Meth.deal12ped1 = World.CreatePed(new Model(850468060), new Vector3(-382.9714f, 3964.177f, 57.44019f), 23.00121f);
                    Meth.deal12ped2 = World.CreatePed(new Model(1032073858), new Vector3(-384.0755f, 3964.24f, 57.44724f), -14.99981f);
                    Meth.deal12ped3 = World.CreatePed(new Model(-44746786), new Vector3(-374.0284f, 3968.86f, 58.13343f), 79.39861f);
                    Meth.deal12ped4 = World.CreatePed(new Model(1330042375), new Vector3(-386.821f, 3971.079f, 55.85037f), -176.5453f);
                    Meth.deal12ped5 = World.CreatePed(new Model(1001210244), new Vector3(-390.5976f, 3960.009f, 58.91197f), 99.01192f);
                    Meth.deal12ped6 = World.CreatePed(new Model(1064866854), new Vector3(-386.3978f, 3970.292f, 55.9568f), 40.54969f);
                    Meth.deal12ped2.Task.StartScenario("WORLD_HUMAN_GUARD_STAND_ARMY", Meth.deal12ped2.Position);
                    Meth.deal12ped3.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.deal12ped3.Position);
                    Meth.deal12ped4.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.deal12ped4.Position);
                    Meth.deal12ped5.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal12ped5.Position);
                    Meth.deal12ped6.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER_HARD", Meth.deal12ped6.Position);
                    Meth.deal12ped1.AddBlip();
                    deal12ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal12ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal12ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal12ped2.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.deal12ped3.Weapons.Give(WeaponHash.MicroSMG, 100, true, false);
                    Meth.deal12ped4.Weapons.Give(WeaponHash.CarbineRifle, 100, true, false);
                    Meth.deal12ped5.Weapons.Give(WeaponHash.BullpupRifle, 100, true, false);
                    Meth.deal12ped6.Weapons.Give(WeaponHash.SMG, 100, true, false);
                    Meth.LastCustomer = 12;
                }
                if (Meth.Customer == 13)
                {
                    Meth.deal13vehicle1 = World.CreateVehicle(new Model(-1150599089), new Vector3(1645.381f, 4840.075f, 41.55758f), 173.8161f);
                    Meth.deal13ped1 = World.CreatePed(new Model(1822107721), new Vector3(1642.083f, 4835.897f, 42.02521f), 174.9498f);
                    Meth.deal13ped2 = World.CreatePed(new Model(-1709285806), new Vector3(1641.204f, 4835.851f, 42.02419f), -161.9165f);
                    Meth.deal13ped2.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal13ped2.Position);
                    Meth.deal13ped1.AddBlip();
                    deal13ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal13ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal13ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal13ped1.Weapons.Give(WeaponHash.KnuckleDuster, 100, true, false);
                    Meth.deal13ped2.Weapons.Give(WeaponHash.Pistol50, 100, true, false);
                    Meth.LastCustomer = 13;
                }
                if (Meth.Customer == 14)
                {
                    Meth.deal14vehicle1 = World.CreateVehicle(new Model(683047626), new Vector3(1308.926f, 4325.389f, 38.38759f), 46.92113f);
                    Meth.deal14ped1 = World.CreatePed(new Model(-236444766), new Vector3(1311.5f, 4326.893f, 38.11893f), -54.99969f);
                    Meth.deal14ped2 = World.CreatePed(new Model(-412008429), new Vector3(1308.6f, 4328.411f, 38.21348f), -95.97929f);
                    Meth.deal14ped3 = World.CreatePed(new Model(-39239064), new Vector3(1311.4f, 4326.204f, 38.1059f), -49.02412f);
                    Meth.deal14ped4 = World.CreatePed(new Model(-984709238), new Vector3(1308.644f, 4322.238f, 38.13105f), 166.0579f);
                    Meth.deal14ped2.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal14ped2.Position);
                    Meth.deal14ped3.Task.StartScenario("WORLD_HUMAN_SMOKING", Meth.deal14ped3.Position);
                    Meth.deal14ped4.Task.StartScenario("WORLD_HUMAN_SMOKING_POT", Meth.deal14ped4.Position);
                    Meth.deal14ped1.AddBlip();
                    deal14ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal14ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal14ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal14ped1.Weapons.Give(WeaponHash.SNSPistol, 100, true, false);
                    Meth.deal14ped2.Weapons.Give(WeaponHash.CombatPistol, 100, true, false);
                    Meth.deal14ped3.Weapons.Give(WeaponHash.AssaultRifle, 100, true, false);
                    Meth.deal14ped4.Weapons.Give(WeaponHash.AssaultRifle, 100, true, false);
                    Meth.LastCustomer = 14;
                }
                if (Meth.Customer == 15)
                {
                    Meth.deal15ped1 = World.CreatePed(new Model(2064532783), new Vector3(726.8161f, 4169.482f, 40.70921f), 2.627836f);
                    Meth.deal15ped1.AddBlip();
                    deal15ped1.AttachedBlip.Sprite = BlipSprite.DollarSignCircled;
                    deal15ped1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.deal15ped1.AttachedBlip.ShowRoute = true;
                    Meth.deal15ped1.Weapons.Give(WeaponHash.APPistol, 100, true, false);
                    Meth.OnDeal = 1;
                    Meth.LastCustomer = 15;
                }
                Meth.previousCustomers.Add(LastCustomer);
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Script error - please cancel the deal and try again");
                QuitAnyCurrent();
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
            }
        }

        public static void DoUpgrade(int upgradeNum)
        {
            Random rnd = new Random();
            try
            {
                upgrade1_part = 0;
                upgrade2_part = 0;
                upgrade3_part = 0;
                upgrade4_part = 0;
                upgrade5_part = 0;
                upgrade6_part = 0;
                upgrade7_part = 0;
                upgrade8_part = 0;
                upgrade9_part = 0;
                upgrade10_part = 0;
                Meth.OnUpgrade = 1;
                Meth.UpgradeMission = upgradeNum;

                if (Meth.UpgradeMission == 1)
                {
                    Meth.SpawnProps();
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Heard of a deal going down. Head to the blip and steal the truck marked on your map.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Get to the blip as soon as you can - there's a truck parked there and you gotta to steal it.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "The chemicals at the blip will upgrade our operation. Steal them.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Head to the blip and steal the Sandking. It's loaded with chemicals we can use to up batch size.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade1_part = 1;
                    Meth.upgrade1vehicle1 = GTA.World.CreateVehicle(new Model(-1189015600), new GTA.Math.Vector3(1527.49f, 1719.386f, 109.9832f), -173.6879f); //Main truck
                    Meth.upgrade1vehicle2 = GTA.World.CreateVehicle(new Model(142944341), new GTA.Math.Vector3(1521.321f, 1711.991f, 109.9413f), -24.00047f);
                    Meth.upgrade1vehicle3 = GTA.World.CreateVehicle(new Model(683047626), new GTA.Math.Vector3(1516.051f, 1736.756f, 110.3977f), -113.6923f);
                    Meth.upgrade1vehicle4 = GTA.World.CreateVehicle(new Model(-394074634), new GTA.Math.Vector3(1515.614f, 1723.972f, 109.8184f), 54.88525f);
                    Meth.upgrade1vehicle5 = GTA.World.CreateVehicle(new Model(410882957), new GTA.Math.Vector3(1530.568f, 1732.291f, 109.8262f), 127.2168f);
                    Meth.upgrade1vehicle6 = GTA.World.CreateVehicle(new Model(989381445), new GTA.Math.Vector3(1533.172f, 1714.981f, 109.7356f), -165.194f);

                    Meth.upgrade1vehicle7 = GTA.World.CreateVehicle(new Model(-394074634), new GTA.Math.Vector3(1404.661f, 2164.737f, 97.77354f), -39.50379f); //Scene 1
                    Meth.upgrade1vehicle8 = GTA.World.CreateVehicle(new Model(-394074634), new GTA.Math.Vector3(1418.099f, 2166.874f, 96.94195f), 25.47694f); //Scene 1
                    Meth.upgrade1vehicle9 = GTA.World.CreateVehicle(new Model(-394074634), new GTA.Math.Vector3(1575.517f, 2199.876f, 78.68687f), 62.37475f); //Scene 2

                    Meth.upgrade1ped15 = GTA.World.CreatePed(new Model(-1561829034), new GTA.Math.Vector3(1401.531f, 2169.873f, 97.76701f), -92.41866f);
                    Meth.upgrade1ped16 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(1416.256f, 2170.812f, 97.04028f), -113.6568f);
                    Meth.upgrade1ped17 = GTA.World.CreatePed(new Model(1746653202), new GTA.Math.Vector3(1417.548f, 2170.411f, 97.003f), 72.64591f);
                    Meth.upgrade1ped18 = GTA.World.CreatePed(new Model(1746653202), new GTA.Math.Vector3(1574.325f, 2197.909f, 79.1595f), 101.3092f);


                    Vector3 rot = new GTA.Math.Vector3(0f, 0f, 0f);
                    Model model = new Model(-1935686084);
                    model.Request(10000);
                    upgrade1barrel1 = GTA.World.CreateProp(model, upgrade1vehicle1.Position, rot, false, false);
                    upgrade1barrel1.SetNoCollision(GTA.Game.Player.Character, true);
                    AttachEntityToEntity(upgrade1barrel1, upgrade1vehicle1, upgrade1vehicle1.GetBoneIndex("bodyshell"), new Vector3(-0.28f, -1.73f, 0.83f), new Vector3(0f, 0f, 130f), false, false, false, 2, true);
                    model.Request(10000);
                    upgrade1barrel2 = GTA.World.CreateProp(model, upgrade1vehicle1.Position, rot, false, false);
                    upgrade1barrel2.SetNoCollision(GTA.Game.Player.Character, true);
                    AttachEntityToEntity(upgrade1barrel2, upgrade1vehicle1, upgrade1vehicle1.GetBoneIndex("bodyshell"), new Vector3(0.35f, -2.43f, 0.83f), new Vector3(0f, 0f, 70f), false, false, false, 2, true);
                    model.Request(10000);
                    upgrade1barrel3 = GTA.World.CreateProp(model, upgrade1vehicle1.Position, rot, false, false);
                    upgrade1barrel3.SetNoCollision(GTA.Game.Player.Character, true);
                    AttachEntityToEntity(upgrade1barrel3, upgrade1vehicle1, upgrade1vehicle1.GetBoneIndex("bodyshell"), new Vector3(-0.38f, -2.83f, 0.83f), new Vector3(0f, 0f, 0f), false, false, false, 2, true);
                    Meth.upgrade1ped1 = GTA.World.CreatePed(new Model(-236444766), new GTA.Math.Vector3(1523.41f, 1716.995f, 109.9647f), 15.15256f);
                    Meth.upgrade1ped2 = GTA.World.CreatePed(new Model(-39239064), new GTA.Math.Vector3(1531.398f, 1729.404f, 109.9239f), 96.99794f);
                    Meth.upgrade1ped3 = GTA.World.CreatePed(new Model(653289389), new GTA.Math.Vector3(1523.59f, 1718.072f, 109.938f), 171.9949f);
                    Meth.upgrade1ped4 = GTA.World.CreatePed(new Model(-306416314), new GTA.Math.Vector3(1522.69f, 1717.877f, 110.0101f), -139.9321f);
                    Meth.upgrade1ped5 = GTA.World.CreatePed(new Model(-9308122), new GTA.Math.Vector3(1530.97f, 1723.696f, 110.1303f), 84.34628f);
                    Meth.upgrade1ped6 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(1516.373f, 1735.015f, 110.2355f), 145.3333f);
                    Meth.upgrade1ped7 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(1515.398f, 1735.341f, 110.2111f), 179.0022f);
                    Meth.upgrade1ped8 = GTA.World.CreatePed(new Model(-48477765), new GTA.Math.Vector3(1519.536f, 1712.766f, 110.2065f), 51.99932f);
                    Meth.upgrade1ped9 = GTA.World.CreatePed(new Model(-1395868234), new GTA.Math.Vector3(1525.239f, 1720.919f, 109.9964f), 86.99884f);
                    Meth.upgrade1ped10 = GTA.World.CreatePed(new Model(691061163), new GTA.Math.Vector3(1519.113f, 1722.291f, 110.2926f), -45.16341f);
                    Meth.upgrade1ped11 = GTA.World.CreatePed(new Model(-1872961334), new GTA.Math.Vector3(1539.237f, 1703.978f, 109.6578f), 107.9994f);
                    Meth.upgrade1ped12 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(1538.304f, 1702.64f, 109.6635f), -38.99947f);
                    Meth.upgrade1ped13 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(1537.909f, 1704.345f, 109.6678f), -92.53496f);
                    Meth.upgrade1ped14 = GTA.World.CreatePed(new Model(1768677545), new GTA.Math.Vector3(1538.656f, 1727.263f, 109.8323f), -74.26968f);
                    Meth.upgrade1ped2.Task.StartScenario("WORLD_HUMAN_DRUG_DEALER", Meth.upgrade1ped2.Position);
                    Meth.upgrade1ped1.Weapons.Give(WeaponHash.Machete, 300, true, false);
                    Meth.upgrade1ped2.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped3.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade1ped4.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped5.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade1ped6.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped7.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade1ped8.Weapons.Give(WeaponHash.HeavyPistol, 300, true, false);
                    Meth.upgrade1ped9.Weapons.Give(WeaponHash.SMG, 300, true, false);
                    Meth.upgrade1ped10.Weapons.Give(WeaponHash.AssaultSMG, 300, true, false);
                    Meth.upgrade1ped11.Weapons.Give(WeaponHash.MarksmanRifle, 300, true, false);
                    Meth.upgrade1ped12.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped13.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade1ped14.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped15.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped16.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped17.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1ped18.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade1vehicle1.AddBlip();
                    upgrade1vehicle1.AttachedBlip.Sprite = BlipSprite.Truck;
                    upgrade1vehicle1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade1vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 1;
                }

                if (Meth.UpgradeMission == 2)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "The Lost MC managed to get ahold of some lab equipment. Go steal it from them.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "There's a trailer full of lab equipment at the location I've sent. You know what to do.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Go work your magic - there's some lab equipment at the blip we need.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Sent the location to your phone. Steal the bikers trailer, it's full of lab equipment.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade2_part = 1;

                    Meth.upgrade2vehicle1 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(246.4641f, 3152.454f, 44.47647f), 89.94525f);
                    Meth.upgrade2vehicle2 = GTA.World.CreateVehicle(new Model(-877478386), new GTA.Math.Vector3(261.8186f, 3113.418f, 44.52674f), -178.7754f);
                    Meth.upgrade2vehicle3 = GTA.World.CreateVehicle(new Model(-2140431165), new GTA.Math.Vector3(264.2597f, 3166.078f, 42.12355f), -23.28482f);
                    Meth.upgrade2vehicle4 = GTA.World.CreateVehicle(new Model(-2128233223), new GTA.Math.Vector3(263.6903f, 3169.688f, 42.09707f), -107.68f);
                    Meth.upgrade2vehicle5 = GTA.World.CreateVehicle(new Model(-1207771834), new GTA.Math.Vector3(246.8931f, 3144.242f, 41.88817f), 119.2207f);
                    Meth.upgrade2vehicle6 = GTA.World.CreateVehicle(new Model(-1453280962), new GTA.Math.Vector3(242.7702f, 3166.022f, 42.23487f), 136.6276f);
                    Meth.upgrade2vehicle7 = GTA.World.CreateVehicle(new Model(741090084), new GTA.Math.Vector3(233.4951f, 3160.77f, 41.89718f), 51.7664f);
                    Meth.upgrade2vehicle8 = GTA.World.CreateVehicle(new Model(833469436), new GTA.Math.Vector3(344.7992f, 3465.745f, 35.32477f), -128.7532f); //Gang event 1
                    Meth.upgrade2vehicle9 = GTA.World.CreateVehicle(new Model(-1745203402), new GTA.Math.Vector3(227.2207f, 2882.327f, 43.3088f), -109.0894f); //Gang event 2
                    Meth.upgrade2vehicle10 = GTA.World.CreateVehicle(new Model(1069929536), new GTA.Math.Vector3(242.081f, 3183.807f, 42.79674f), 123.6404f);

                    Meth.upgrade2ped1 = GTA.World.CreatePed(new Model(1032073858), new GTA.Math.Vector3(243.1876f, 3168.701f, 42.8461f), -106.2888f);
                    Meth.upgrade2ped2 = GTA.World.CreatePed(new Model(850468060), new GTA.Math.Vector3(244.3157f, 3168.106f, 42.82878f), 64.99089f);
                    Meth.upgrade2ped3 = GTA.World.CreatePed(new Model(1330042375), new GTA.Math.Vector3(263.1049f, 3172.014f, 42.61808f), -43.10589f);
                    Meth.upgrade2ped4 = GTA.World.CreatePed(new Model(-44746786), new GTA.Math.Vector3(263.803f, 3172.665f, 42.5453f), 136.7907f);
                    Meth.upgrade2ped5 = GTA.World.CreatePed(new Model(1626646295), new GTA.Math.Vector3(243.4767f, 3140.667f, 42.48498f), 9.081732f);
                    Meth.upgrade2ped6 = GTA.World.CreatePed(new Model(-1773858377), new GTA.Math.Vector3(244.1639f, 3141.838f, 42.45826f), 141.9988f);
                    Meth.upgrade2ped7 = GTA.World.CreatePed(new Model(-1299428795), new GTA.Math.Vector3(242.7615f, 3141.828f, 42.44957f), -115.9992f);
                    Meth.upgrade2ped8 = GTA.World.CreatePed(new Model(850468060), new GTA.Math.Vector3(343.7276f, 3462.584f, 35.74516f), -16.00084f); //Gang event 1
                    Meth.upgrade2ped9 = GTA.World.CreatePed(new Model(1032073858), new GTA.Math.Vector3(343.617f, 3463.599f, 35.75167f), 149.1334f); //Gang event 1
                    Meth.upgrade2ped10 = GTA.World.CreatePed(new Model(1330042375), new GTA.Math.Vector3(342.5839f, 3463.254f, 35.76863f), -61.99973f); //Gang event 1
                    Meth.upgrade2ped11 = GTA.World.CreatePed(new Model(-984709238), new GTA.Math.Vector3(227.8388f, 2884.177f, 43.46758f), -46.99897f); //Gang event 2
                    Meth.upgrade2ped12 = GTA.World.CreatePed(new Model(-39239064), new GTA.Math.Vector3(229.1046f, 2883.65f, 43.49247f), 3.259262f); //Gang event 2

                    Meth.upgrade2ped1.Weapons.Give(WeaponHash.Revolver, 300, true, false);
                    Meth.upgrade2ped2.Weapons.Give(WeaponHash.DoubleBarrelShotgun, 300, true, false);
                    Meth.upgrade2ped3.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade2ped4.Weapons.Give(WeaponHash.DoubleBarrelShotgun, 300, true, false);
                    Meth.upgrade2ped5.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade2ped6.Weapons.Give(WeaponHash.HeavyPistol, 300, true, false);
                    Meth.upgrade2ped7.Weapons.Give(WeaponHash.CompactRifle, 300, true, false);
                    Meth.upgrade2ped8.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    Meth.upgrade2ped9.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade2ped10.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade2ped11.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade2ped12.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);

                    Meth.upgrade2vehicle1.AddBlip();
                    upgrade2vehicle1.AttachedBlip.Sprite = BlipSprite.Trailer;
                    upgrade2vehicle1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade2vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 2;
                }

                if (Meth.UpgradeMission == 3)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "There's a Blazer at the blip with some supplies in. Steal it.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "There is a deal going down at the blip - steal the Blazer and crate.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Some local gangs are making a deal at the blip. Steal their crate.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Steal the crate at the blip. It should be strapped to the back of a Blazer.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade3_part = 1;

                    Meth.upgrade3vehicle1 = GTA.World.CreateVehicle(new Model(-1590337689), new GTA.Math.Vector3(1359.492f, 4367.401f, 43.8379f), 156.484f); //Blazer aqua
                    Meth.upgrade3vehicle2 = GTA.World.CreateVehicle(new Model(-1590337689), new GTA.Math.Vector3(1353.455f, 4366.292f, 43.84185f), 22.96266f); //Blazer false
                    Meth.upgrade3vehicle3 = GTA.World.CreateVehicle(new Model(-1590337689), new GTA.Math.Vector3(1357.915f, 4375.192f, 43.86413f), -141.0174f); //Blazer false
                    Meth.upgrade3vehicle4 = GTA.World.CreateVehicle(new Model(-808831384), new GTA.Math.Vector3(1385.765f, 4378.497f, 43.46906f), 134.3735f); //Baller
                    Meth.upgrade3vehicle5 = GTA.World.CreateVehicle(new Model(-2030171296), new GTA.Math.Vector3(1376.564f, 4363.88f, 43.38467f), 37.44493f); //Cognoscenti
                    Meth.upgrade3vehicle6 = GTA.World.CreateVehicle(new Model(-1237253773), new GTA.Math.Vector3(1364.246f, 4379.04f, 44.20669f), -30.88138f); //Dubsta 6 wheeler
                    Meth.upgrade3vehicle7 = GTA.World.CreateVehicle(new Model(-1661854193), new GTA.Math.Vector3(1343.403f, 4366.336f, 43.79815f), -70.81923f); //Dune buggy
                    Meth.upgrade3vehicle8 = GTA.World.CreateVehicle(new Model(276773164), new GTA.Math.Vector3(1338.533f, 4280.577f, 30.70993f), -159.6408f); //Boat
                    upgrade3vehicle8.IsPositionFrozen = true;

                    Vector3 rot = new GTA.Math.Vector3(0f, 0f, 0f);
                    Model model = new Model(1877891248);
                    model.Request(10000);
                    upgrade3crate1 = GTA.World.CreateProp(model, upgrade3vehicle1.Position, rot, false, false);
                    upgrade3crate1.SetNoCollision(GTA.Game.Player.Character, true);
                    AttachEntityToEntity(upgrade3crate1, upgrade3vehicle1, upgrade3vehicle1.GetBoneIndex("bodyshell"), new Vector3(0.01f, -0.76f, 0.69f), new Vector3(0f, 0f, 90f), false, false, false, 2, true);

                    Meth.upgrade3ped1 = GTA.World.CreatePed(new Model(-1109568186), new GTA.Math.Vector3(1369.592f, 4366.989f, 44.35347f), 66.99814f); //Mex
                    Meth.upgrade3ped2 = GTA.World.CreatePed(new Model(1466037421), new GTA.Math.Vector3(1368.883f, 4367.682f, 44.35664f), 84.2487f); //Mex boss
                    Meth.upgrade3ped3 = GTA.World.CreatePed(new Model(653210662), new GTA.Math.Vector3(1372.955f, 4362.504f, 44.28195f), -35.98015f); //Mex
                    Meth.upgrade3ped4 = GTA.World.CreatePed(new Model(832784782), new GTA.Math.Vector3(1369.76f, 4368.032f, 44.36926f), 103.9989f); //Mex
                    Meth.upgrade3ped5 = GTA.World.CreatePed(new Model(-1773333796), new GTA.Math.Vector3(1372.061f, 4380.071f, 44.44684f), 173.601f); //Mex
                    Meth.upgrade3ped6 = GTA.World.CreatePed(new Model(-1872961334), new GTA.Math.Vector3(1367.414f, 4367.726f, 44.34414f), -86.99913f); //Gang boss
                    Meth.upgrade3ped7 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(1366.828f, 4368.63f, 44.38201f), -94.99944f); //Gang
                    Meth.upgrade3ped8 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(1366.573f, 4366.807f, 44.34046f), -65.99858f); //Gang
                    Meth.upgrade3ped9 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(1365.113f, 4376.362f, 44.33229f), -150.0214f); //Gang
                    Meth.upgrade3ped10 = GTA.World.CreatePed(new Model(1657546978), new GTA.Math.Vector3(1352.012f, 4378.236f, 44.34339f), 158.5874f); //Marine mech
                    Meth.upgrade3ped11 = GTA.World.CreatePed(new Model(-1806291497), new GTA.Math.Vector3(1334.617f, 4281.201f, 31.95599f), -2.965704f); //Boat farmer
                    Meth.upgrade3ped12 = GTA.World.CreatePed(new Model(832784782), new GTA.Math.Vector3(1334.108f, 4282.262f, 31.96284f), -110.9856f); //Boat Mex1
                    Meth.upgrade3ped13 = GTA.World.CreatePed(new Model(1226102803), new GTA.Math.Vector3(1335.069f, 4282.869f, 31.97103f), 169.6599f); //Boat Mex2

                    Meth.upgrade3ped2.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade3ped3.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade3ped4.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);
                    Meth.upgrade3ped5.Weapons.Give(WeaponHash.HeavyShotgun, 300, true, false);
                    Meth.upgrade3ped6.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade3ped8.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    Meth.upgrade3ped9.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade3ped10.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade3ped12.Weapons.Give(WeaponHash.HeavyPistol, 300, true, false);
                    Meth.upgrade3ped13.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);

                    Meth.upgrade3vehicle1.AddBlip();
                    upgrade3vehicle1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    upgrade3vehicle1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade3vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 3;
                }

                if (Meth.UpgradeMission == 4)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "You need to take down an enemy gang boss so we can expand our operation.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Kill the gang boss at the location, then we can take their territory.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "This dude is causing us some problems. Take him out so we can expand further.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Go to the location I've sent and kill the target, he is a rival meth supplier.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    TextNotification("CHAR_MP_STRETCH", "~b~Ron", "Photo message", "Here's a picture of the target.");
                    upgrade4_part = 1;

                    Meth.upgrade4vehicle1 = GTA.World.CreateVehicle(new Model(-1045541610), new GTA.Math.Vector3(591.3066f, 2789.264f, 41.75668f), -68.0082f);
                    Meth.upgrade4vehicle2 = GTA.World.CreateVehicle(new Model(634118882), new GTA.Math.Vector3(572.5638f, 2811.909f, 41.92053f), -59.77626f);
                    Meth.upgrade4vehicle3 = GTA.World.CreateVehicle(new Model(470404958), new GTA.Math.Vector3(584.0295f, 2787.847f, 42.10477f), 60.98061f);
                    Meth.upgrade4vehicle4 = GTA.World.CreateVehicle(new Model(-1041692462), new GTA.Math.Vector3(644.8695f, 2803.136f, 41.4424f), 29.24689f);
                    Meth.upgrade4vehicle5 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(613.2159f, 2794.607f, 42.3051f), 12.7858f);
                    Meth.upgrade4vehicle6 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(605.49f, 2794.889f, 42.28812f), 9.250314f);
                    Meth.upgrade4vehicle7 = GTA.World.CreateVehicle(new Model(729783779), new GTA.Math.Vector3(567.3011f, 2805.429f, 41.68729f), -136.3322f);
                    Meth.upgrade4vehicle8 = GTA.World.CreateVehicle(new Model(833469436), new GTA.Math.Vector3(617.7423f, 2806.427f, 41.56831f), 145.1322f);
                    Meth.upgrade4vehicle9 = GTA.World.CreateVehicle(new Model(-1207771834), new GTA.Math.Vector3(600.2106f, 2814.089f, 41.5104f), 67.33185f);
                    Meth.upgrade4vehicle10 = GTA.World.CreateVehicle(new Model(-1237253773), new GTA.Math.Vector3(624.9666f, 2815.154f, 41.74499f), 114.5348f);
                    Meth.upgrade4vehicle11 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(585.954f, 2812.867f, 42.04877f), -83.46241f);
                    Meth.upgrade4vehicle12 = GTA.World.CreateVehicle(new Model(1491375716), new GTA.Math.Vector3(577.6957f, 2797.949f, 41.58521f), 167.7358f);
                    Meth.upgrade4vehicle13 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(640.2717f, 2815.263f, 42.17973f), 80.77163f);


                    Meth.upgrade4ped1 = GTA.World.CreatePed(new Model(915948376), new GTA.Math.Vector3(569.9863f, 2798.275f, 42.0151f), -78.99911f); //Target - Stretch
                    Meth.upgrade4ped2 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(626.0748f, 2813.818f, 41.92717f), -127.9942f);
                    Meth.upgrade4ped3 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(568.9796f, 2800.857f, 42.01758f), -113.8988f);
                    Meth.upgrade4ped4 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(585.6151f, 2789.813f, 42.19036f), -8.761761f);
                    Meth.upgrade4ped5 = GTA.World.CreatePed(new Model(-1872961334), new GTA.Math.Vector3(590.4219f, 2790.818f, 42.17429f), 31.99987f);
                    Meth.upgrade4ped6 = GTA.World.CreatePed(new Model(891945583), new GTA.Math.Vector3(571.7787f, 2797.711f, 42.01931f), 77.34808f);
                    Meth.upgrade4ped7 = GTA.World.CreatePed(new Model(2093736314), new GTA.Math.Vector3(571.2259f, 2799.434f, 42.00717f), 133.3489f);
                    Meth.upgrade4ped8 = GTA.World.CreatePed(new Model(-1880237687), new GTA.Math.Vector3(599.434f, 2812.423f, 41.94796f), -176.1076f);
                    Meth.upgrade4ped9 = GTA.World.CreatePed(new Model(611648169), new GTA.Math.Vector3(599.3298f, 2811.287f, 41.96135f), -40.99991f);
                    Meth.upgrade4ped10 = GTA.World.CreatePed(new Model(611648169), new GTA.Math.Vector3(589.8497f, 2791.869f, 42.14715f), -152.9985f);
                    Meth.upgrade4ped11 = GTA.World.CreatePed(new Model(-1880237687), new GTA.Math.Vector3(585.5786f, 2790.99f, 42.16109f), 178.0007f);
                    Meth.upgrade4ped12 = GTA.World.CreatePed(new Model(653210662), new GTA.Math.Vector3(570.9409f, 2796.993f, 42.01257f), 22.43985f);
                    Meth.upgrade4ped13 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(600.4405f, 2811.51f, 41.95945f), 72.64059f);
                    Meth.upgrade4ped14 = GTA.World.CreatePed(new Model(1329576454), new GTA.Math.Vector3(598.9904f, 2784.715f, 43.48364f), 24.69019f);
                    Meth.upgrade4ped15 = GTA.World.CreatePed(new Model(-1561829034), new GTA.Math.Vector3(574.7351f, 2810.993f, 41.98013f), -114.1324f);
                    Meth.upgrade4ped16 = GTA.World.CreatePed(new Model(653210662), new GTA.Math.Vector3(627.3273f, 2813.238f, 41.98621f), 78.12077f);
                    Meth.upgrade4ped17 = GTA.World.CreatePed(new Model(810804565), new GTA.Math.Vector3(626.1317f, 2812.529f, 41.98296f), 8.000053f);
                    Meth.upgrade4ped18 = GTA.World.CreatePed(new Model(832784782), new GTA.Math.Vector3(616.8279f, 2807.398f, 41.93616f), 51.22027f);
                    Meth.upgrade4ped19 = GTA.World.CreatePed(new Model(1226102803), new GTA.Math.Vector3(615.6328f, 2813.778f, 41.94604f), -72.62566f);
                    Meth.upgrade4ped20 = GTA.World.CreatePed(new Model(1466037421), new GTA.Math.Vector3(615.8603f, 2814.927f, 41.9325f), -128.9988f);
                    Meth.upgrade4ped21 = GTA.World.CreatePed(new Model(-1773333796), new GTA.Math.Vector3(616.8854f, 2814.808f, 41.93087f), 146.9942f);
                    Meth.upgrade4ped22 = GTA.World.CreatePed(new Model(-1109568186), new GTA.Math.Vector3(616.9938f, 2813.509f, 41.94658f), 50.99944f);
                    Meth.upgrade4ped23 = GTA.World.CreatePed(new Model(32417469), new GTA.Math.Vector3(567.2343f, 2796.939f, 47.1707f), -75.99897f);
                    Meth.upgrade4ped24 = GTA.World.CreatePed(new Model(-1463670378), new GTA.Math.Vector3(642.1859f, 2806.918f, 41.89315f), -82.93587f);
                    Meth.upgrade4ped25 = GTA.World.CreatePed(new Model(-9308122), new GTA.Math.Vector3(643.4444f, 2806.316f, 41.86181f), 54.99777f);

                    Meth.upgrade4ped1.Weapons.Give(WeaponHash.Machete, 300, true, false);
                    Meth.upgrade4ped2.Weapons.Give(WeaponHash.MarksmanRifle, 300, true, false);
                    Meth.upgrade4ped3.Weapons.Give(WeaponHash.SniperRifle, 300, true, false);
                    Meth.upgrade4ped4.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);
                    Meth.upgrade4ped5.Weapons.Give(WeaponHash.HeavyShotgun, 300, true, false);
                    Meth.upgrade4ped6.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade4ped8.Weapons.Give(WeaponHash.SMG, 300, true, false);
                    Meth.upgrade4ped9.Weapons.Give(WeaponHash.SniperRifle, 300, true, false);
                    Meth.upgrade4ped10.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade4ped12.Weapons.Give(WeaponHash.CombatPDW, 300, true, false);
                    Meth.upgrade4ped13.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);
                    Meth.upgrade4ped15.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    Meth.upgrade4ped16.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade4ped17.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade4ped18.Weapons.Give(WeaponHash.HeavyPistol, 300, true, false);
                    Meth.upgrade4ped19.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);
                    Meth.upgrade4ped20.Weapons.Give(WeaponHash.CombatPDW, 300, true, false);
                    Meth.upgrade4ped21.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    Meth.upgrade4ped22.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);
                    Meth.upgrade4ped23.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade4ped24.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade4ped25.Weapons.Give(WeaponHash.Pistol, 300, true, false);

                    Meth.upgrade4ped1.AddBlip();
                    Meth.upgrade4ped1.AttachedBlip.Sprite = BlipSprite.BountyHit;
                    Meth.upgrade4ped1.AttachedBlip.Color = BlipColor.Red;
                    Meth.upgrade4ped1.AttachedBlip.ShowRoute = true;

                    Meth.upgrade4_targetspot = 0;
                    Meth.upgrade4_targetspooked = 0;
                    Meth.LastUpgrade = 4;

                }

                if (Meth.UpgradeMission == 5)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Get to the motel near the lab. There's a crate of chemicals we need.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "There's a crate being held in a building near the lab. Steal it.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "At the blip there are some chemicals we need being held. Steal it.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Bring the crate at the blip back to the lab, we need it.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade5_part = 1;

                    Meth.upgrade5vehicle1 = GTA.World.CreateVehicle(new Model(683047626), new GTA.Math.Vector3(1598.661f, 3608.97f, 35.37614f), -155.058f);
                    Meth.upgrade5vehicle2 = GTA.World.CreateVehicle(new Model(833469436), new GTA.Math.Vector3(1615.82f, 3598.637f, 34.77635f), 45.21072f);
                    Meth.upgrade5vehicle3 = GTA.World.CreateVehicle(new Model(296357396), new GTA.Math.Vector3(1575.516f, 3587.841f, 35.18399f), 106.9959f);
                    Meth.upgrade5vehicle4 = GTA.World.CreateVehicle(new Model(301427732), new GTA.Math.Vector3(1599.901f, 3596.937f, 34.89944f), -5.287963f);

                    Vector3 rot = new GTA.Math.Vector3(0f, 0f, 0f);
                    Model model = new Model(1370563384);
                    model.Request(10000);
                    upgrade5crate1 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1600.853f, 3588.306f, 37.77152f), rot, false, false);
                    upgrade5crate1.SetNoCollision(GTA.Game.Player.Character, true);

                    Meth.upgrade5ped1 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(1598.11f, 3586.552f, 38.76704f), 88.57852f);
                    Meth.upgrade5ped2 = GTA.World.CreatePed(new Model(-1872961334), new GTA.Math.Vector3(1592.519f, 3587.028f, 38.76751f), -111.154f);
                    Meth.upgrade5ped3 = GTA.World.CreatePed(new Model(-681546704), new GTA.Math.Vector3(1593.751f, 3587.881f, 38.7688f), -162.3806f);
                    Meth.upgrade5ped4 = GTA.World.CreatePed(new Model(663522487), new GTA.Math.Vector3(1593.65f, 3586.41f, 38.76919f), 51.99967f);
                    Meth.upgrade5ped5 = GTA.World.CreatePed(new Model(832784782), new GTA.Math.Vector3(1616.05f, 3567.361f, 38.78409f), 21.99969f);
                    Meth.upgrade5ped6 = GTA.World.CreatePed(new Model(846439045), new GTA.Math.Vector3(1603.82f, 3560.071f, 38.73138f), 69.99876f);
                    Meth.upgrade5ped7 = GTA.World.CreatePed(new Model(1329576454), new GTA.Math.Vector3(1594.071f, 3577.838f, 38.75615f), 128.018f);
                    Meth.upgrade5ped8 = GTA.World.CreatePed(new Model(2119136831), new GTA.Math.Vector3(1586.712f, 3594.283f, 38.73155f), 128.8141f);
                    Meth.upgrade5ped9 = GTA.World.CreatePed(new Model(-1773333796), new GTA.Math.Vector3(1579.896f, 3621.219f, 38.73136f), -32.01563f);
                    Meth.upgrade5ped10 = GTA.World.CreatePed(new Model(-1561829034), new GTA.Math.Vector3(1577.894f, 3605.896f, 38.78328f), 138.095f);
                    Meth.upgrade5ped11 = GTA.World.CreatePed(new Model(-984709238), new GTA.Math.Vector3(1593.43f, 3593.918f, 38.769f), 167.6748f);
                    Meth.upgrade5ped12 = GTA.World.CreatePed(new Model(-39239064), new GTA.Math.Vector3(1593.209f, 3592.634f, 38.76881f), -4.999965f);
                    Meth.upgrade5ped13 = GTA.World.CreatePed(new Model(62440720), new GTA.Math.Vector3(1569.699f, 3598.261f, 38.73359f), -85.33544f);

                    Meth.upgrade5ped1.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade5ped2.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade5ped3.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);
                    Meth.upgrade5ped4.Weapons.Give(WeaponHash.HeavyShotgun, 300, true, false);
                    Meth.upgrade5ped5.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade5ped6.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    Meth.upgrade5ped7.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade5ped8.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    Meth.upgrade5ped9.Weapons.Give(WeaponHash.HeavyPistol, 300, true, false);
                    Meth.upgrade5ped10.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade5ped11.Weapons.Give(WeaponHash.Revolver, 300, true, false);
                    Meth.upgrade5ped12.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade5ped13.Weapons.Give(WeaponHash.Pistol, 300, true, false);

                    Meth.upgrade5crate1.AddBlip();
                    upgrade5crate1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                    upgrade5crate1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade5crate1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 5;
                }

                if (Meth.UpgradeMission == 6)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Drive over to the airfield, we have a few 'problems' that need sorting out.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "There are a few gangs stealing our business! Let's resolve that.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Local gangs are becoming an issue. Let's show them who they're dealing with!";
                    }
                    else if (chooser == 4)
                    {
                        TextNotification("CHAR_RON", "~b~Ron", "Text message", "We need to iron out a few creases in our business. Head to the blip to get started.");
                        msg2do = "And by creases, I mean gangs and by iron out, I mean blast with an explosive cannon - just FYI!";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade6_part = 1;


                    Meth.upgrade6vehicle1 = GTA.World.CreateVehicle(new Model(970385471), new GTA.Math.Vector3(1713.198f, 3245.559f, 41.60305f), 72.62683f); //Hydra

                    Meth.upgrade6vehicle1.AddBlip();
                    upgrade6vehicle1.AttachedBlip.Sprite = BlipSprite.PlaneDrop;
                    upgrade6vehicle1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade6vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 6;
                }

                if (Meth.UpgradeMission == 7)
                {
                    upgrade7hostile = false;
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "There's a Humane Labs van you need to locate and hijack.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "We're in need of some new lab equipment. Hijack the van at the blip.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Hijack that van before it gets to Humane Labs. And watch out for their escorts!";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Take out the security team and hijack that van before it gets to Humane Labs.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade7_part = 1;


                    Meth.upgrade7vehicle1 = GTA.World.CreateVehicle(new Model(121658888), new GTA.Math.Vector3(1720.331f, 3771.685f, 34.19107f), -60.82315f); //Main boxville
                    Meth.upgrade7vehicle2 = GTA.World.CreateVehicle(new Model(1922255844), new GTA.Math.Vector3(1718.024f, 3760.726f, 33.71086f), 27.14984f);
                    Meth.upgrade7vehicle3 = GTA.World.CreateVehicle(new Model(1922255844), new GTA.Math.Vector3(1716.373f, 3783.111f, 34.19432f), -99.78946f);
                    Meth.upgrade7vehicle4 = GTA.World.CreateVehicle(new Model(788747387), new GTA.Math.Vector3(1733.465f, 3725.261f, 33.88317f), -19.82791f); //Heli

                    Meth.upgrade7ped1 = GTA.World.CreatePed(new Model(1631478380), new GTA.Math.Vector3(1720.118f, 3774.807f, 34.36997f), -48.46706f);
                    Meth.upgrade7ped2 = GTA.World.CreatePed(new Model(-166363761), new GTA.Math.Vector3(1720.743f, 3775.624f, 34.38486f), 175.9996f);
                    Meth.upgrade7ped3 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1714.772f, 3781.083f, 34.60204f), -118.154f); //Car 2
                    Meth.upgrade7ped5 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1716.026f, 3780.612f, 34.57866f), 86.00036f); //Car 1
                    Meth.upgrade7ped4 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1716.631f, 3759.527f, 34.14696f), 69.98949f); //Car 2
                    Meth.upgrade7ped6 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1715.553f, 3760.313f, 34.16565f), -133.9966f); //Car1 
                    Meth.upgrade7ped7 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1737.369f, 3726.708f, 33.9486f), -98.17947f); //Heli
                    Meth.upgrade7ped8 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1738.994f, 3727.743f, 33.93015f), -169.9842f); //Heli
                    Meth.upgrade7ped9 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1738.587f, 3725.284f, 33.96076f), 13.99961f); //Heli
                    Meth.upgrade7ped10 = GTA.World.CreatePed(new Model(788443093), new GTA.Math.Vector3(1739.952f, 3725.922f, 33.9471f), 55.04275f); //Heli

                    Meth.upgrade7ped1.Weapons.Give(WeaponHash.Nightstick, 300, true, false);
                    Meth.upgrade7ped2.Weapons.Give(WeaponHash.Pistol, 300, true, false);

                    Meth.upgrade7ped4.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade7ped3.Weapons.Give(WeaponHash.APPistol, 300, true, false);

                    Meth.upgrade7ped5.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade7ped6.Weapons.Give(WeaponHash.APPistol, 300, true, false);

                    Meth.upgrade7ped7.Weapons.Give(WeaponHash.Pistol, 300, true, false);
                    Meth.upgrade7ped8.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    Meth.upgrade7ped9.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);
                    Meth.upgrade7ped10.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);

                    Meth.upgrade7vehicle1.AddBlip();
                    upgrade7vehicle1.AttachedBlip.Sprite = BlipSprite.Truck;
                    upgrade7vehicle1.AttachedBlip.Color = BlipColor.Green;
                    Meth.upgrade7vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 7;

                    upgrade7ped7.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.Driver);
                    upgrade7ped8.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.Passenger);
                    upgrade7ped9.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.LeftRear);
                    upgrade7ped10.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.RightRear);

                }

                if (Meth.UpgradeMission == 8)
                {
                    int chooser = rnd.Next(1, 4);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Head over to the airfield and jump in the chopper waiting for you.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Go to the airfield, you need to deliver some packages for my contact.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "You need to do a job for a friend of mine. Get to the airfield.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade8_part = 1;

                    runParticleOnEntityPos("des_methtrailer", "ent_ray_meth_explosion", new Vector3(0f, 0f, 0f), 0.75f);
                    runParticleOnEntityPos("core", "exp_grd_sticky_sp", new Vector3(0f, 0f, 0f), 1f);
                    runParticleOnEntityPos("scr_exile1", "scr_ex1_dust_impact", new Vector3(0f, 0f, 0f), 0.08f);

                    Meth.upgrade8vehicle1 = GTA.World.CreateVehicle(new Model(744705981), new GTA.Math.Vector3(1718.7769f, 3243.0417f, 41.84519f), 104.8894f); //Frogger

                    Meth.upgrade8vehicle1.AddBlip();
                    upgrade8vehicle1.AttachedBlip.Sprite = BlipSprite.Helicopter;
                    upgrade8vehicle1.AttachedBlip.Color = BlipColor.Blue;
                    Meth.upgrade8vehicle1.AttachedBlip.ShowRoute = true;
                    Meth.LastUpgrade = 8;
                }

                if (Meth.UpgradeMission == 9)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "That truck is filled with methylamine, which will allow us to cook even larger batches.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "Methylamine is exactly what we need to increase our yields - go get that truck!";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "My connect says this should be an easy one, no security just walk in and steal it!";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Go locate that truck, it should just be sitting there abandoned!";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade9_part = 1;
                    LastUpgrade = 9;

                    bl = World.CreateBlip(upgrade9_marker1);
                    bl.Sprite = BlipSprite.Truck;
                    bl.Color = BlipColor.Green;
                    bl.ShowRoute = true;
                }

                if (Meth.UpgradeMission == 10)
                {
                    int chooser = rnd.Next(1, 5);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "You need to take these guys out, they're affecting our business.";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "These guys are causing us some problems. Check your GPS and sort it.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Head over to the location I've sent and do what needs to be done.";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "You know what to do. Check your GPS for the location of the first target.";
                    }
                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                    upgrade10_part = 1;


                    Meth.upgrade10vehicle1 = GTA.World.CreateVehicle(new Model(296357396), new GTA.Math.Vector3(1758.02f, 3345.653f, 40.83251f), 161.4725f);
                    Meth.upgrade10ped1 = GTA.World.CreatePed(new Model(-459818001), new GTA.Math.Vector3(1762.698f, 3342.431f, 41.06026f), -21.99943f);
                    Meth.upgrade10ped2 = GTA.World.CreatePed(new Model(-2077218039), new GTA.Math.Vector3(1762.708f, 3343.792f, 41.01034f), -168.9985f);

                    Meth.upgrade10ped1.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    Meth.upgrade10ped2.Weapons.Give(WeaponHash.VintagePistol, 300, true, false);

                    Meth.upgrade10ped1.AddBlip();
                    upgrade10ped1.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                    upgrade10ped1.AttachedBlip.Color = BlipColor.Red;
                    Meth.upgrade10ped2.AddBlip();
                    upgrade10ped2.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                    upgrade10ped2.AttachedBlip.Color = BlipColor.Red;

                    Meth.LastUpgrade = 10;
                }

                turnUpgradeTeam();

                if (quit_key_toggle == 1)
                {
                    GTA.UI.Notification.Show("Hit " + ReturnButtonString(quit_key) + " to cancel the mission.");
                }
            }
            catch (Exception e)
            {
                GTA.UI.Notification.Show("~r~Script error - please cancel the mission and try again");
                GTA.UI.Notification.Show(e.ToString());
                QuitAnyCurrent();
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
            }
        }

        public static void SpawnProps()
        {
            if (propSpawn == 0)
            {
                List<int> Props = new List<int>();
                int LodDistance = 3000;

                Func<int, Vector3, Vector3, bool, int> createProp = new Func<int, Vector3, Vector3, bool, int>(delegate (int hash, Vector3 pos, Vector3 rot, bool dynamic)
                {
                    Model model = new Model(hash);
                    //model.Request(10000);
                    Prop prop = GTA.World.CreateProp(model, pos, rot, dynamic, false);
                    prop.Position = pos;
                    prop.LodDistance = LodDistance;
                    if (!dynamic)
                        prop.IsPositionFrozen = true;
                    return prop.Handle;
                });

                // Upgrade mission 1 exp. barrels
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1528.465f, 1710.933f, 109.41f), new GTA.Math.Vector3(0f, 0f, 150.0007f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1528.95f, 1710.313f, 109.4f), new GTA.Math.Vector3(0f, 0f, -147.9992f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1527.616f, 1712.399f, 109.43f), new GTA.Math.Vector3(0f, 0f, -22.99841f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1532.224f, 1722.282f, 109.44f), new GTA.Math.Vector3(1.001791E-05f, 5.008955E-06f, -121f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1532.655f, 1721.592f, 109.43f), new GTA.Math.Vector3(1.001791E-05f, 5.00894E-06f, 123f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1531.05f, 1724.975f, 109.54f), new GTA.Math.Vector3(1.00179E-05f, 5.008893E-06f, 123f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1528.902f, 1711.807f, 109.41f), new GTA.Math.Vector3(1.001787E-05f, 5.008874E-06f, -118.0002f), false));
                Props.Add(createProp(-1935686084, new GTA.Math.Vector3(1519.173f, 1720.76f, 109.75f), new GTA.Math.Vector3(1.001786E-05f, 5.008846E-06f, 63.99942f), false));
                // Upgrade mission 4 assasination crates
                Props.Add(createProp(758360035, new GTA.Math.Vector3(574.0657f, 2792.19f, 41.65f), new GTA.Math.Vector3(-0.5000144f, -5.122643E-06f, 111.9986f), false));
                Props.Add(createProp(758360035, new GTA.Math.Vector3(576.8405f, 2791.48f, 41.71f), new GTA.Math.Vector3(-1.249996f, 5.01592E-06f, 70.49761f), false));
                Props.Add(createProp(758360035, new GTA.Math.Vector3(573.0624f, 2793.868f, 41.62f), new GTA.Math.Vector3(1.328736E-05f, -0.5000057f, 37.49697f), false));
                Props.Add(createProp(758360035, new GTA.Math.Vector3(571.6452f, 2792.508f, 41.62f), new GTA.Math.Vector3(3.969332E-12f, 5.008956E-06f, 70.2489f), false));
                Props.Add(createProp(758360035, new GTA.Math.Vector3(580.3785f, 2791.58f, 41.73f), new GTA.Math.Vector3(1.750016f, -0.500006f, 112.9979f), false));

                propSpawn = 1;
            }
        }
        //-----------------------

        public static void UpgradeMission1Follow()
        { //This is the most hacky horrible piece of code I've ever written god damn
            if (upgrademission1counter == 0)
            {
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped1, upgrade1vehicle4, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped2, upgrade1vehicle4, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped3, upgrade1vehicle4, 20000, 1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped4, upgrade1vehicle4, 20000, 2, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped5, upgrade1vehicle5, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped6, upgrade1vehicle5, 20000, 0, 5, 16, 0);

                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped15, upgrade1vehicle7, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped16, upgrade1vehicle7, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped17, upgrade1vehicle8, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade1ped18, upgrade1vehicle9, 20000, -1, 5, 16, 0);
            }
            upgrademission1counter += 1;
            if (upgrademission1counter < 7)
            {
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade1ped1, upgrade1vehicle4, upgrade1vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade1ped5, upgrade1vehicle5, upgrade1vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade1ped15, upgrade1vehicle7, upgrade1vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade1ped17, upgrade1vehicle8, upgrade1vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade1ped18, upgrade1vehicle9, upgrade1vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
            }
        }

        public static void UpgradeMission2Follow()
        { //This is the most hacky horrible piece of code I've ever written god damn
            if (upgrademission2counter == 0)
            {
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped1, upgrade2vehicle6, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped2, upgrade2vehicle7, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped3, upgrade2vehicle4, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped4, upgrade2vehicle3, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped5, upgrade2vehicle5, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped6, upgrade2vehicle5, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped7, upgrade2vehicle5, 20000, 1, 5, 16, 0);
            }
            upgrademission2counter += 1;
            if (upgrademission2counter < 7)
            {
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped1, upgrade2vehicle6, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped2, upgrade2vehicle7, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped3, upgrade2vehicle4, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped4, upgrade2vehicle3, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped5, upgrade2vehicle5, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
            }
        }

        public static void UpgradeMission21Follow()
        { //This is the most hacky horrible piece of code I've ever written god damn
            if (upgrademission21counter == 0)
            {
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped8, upgrade2vehicle8, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped9, upgrade2vehicle8, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped10, upgrade2vehicle8, 20000, 1, 5, 16, 0);
                turnHostileUpgrade();

                Random rnd = new Random();
                int chooser = rnd.Next(4300, 12864);
                Script.Wait(chooser);

                chooser = rnd.Next(1, 4);
                string msg2do = "";
                if (chooser == 1)
                {
                    msg2do = "Take a longer route to avoid bringing heat back to the lab.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Those bikers are on to us - don't let them get the trailer!";
                }
                else if (chooser == 3)
                {
                    msg2do = "Don't let those bikers get that trailer back!";
                }

                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            upgrademission21counter += 1;
            if (upgrademission21counter < 7)
            {
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped8, upgrade2vehicle8, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
            }
        }

        public static void UpgradeMission22Follow()
        { //This is the most hacky horrible piece of code I've ever written god damn
            if (upgrademission22counter == 0)
            {
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped11, upgrade2vehicle9, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade2ped12, upgrade2vehicle9, 20000, 0, 5, 16, 0);
                turnHostileUpgrade();

                Random rnd = new Random();
                int chooser = rnd.Next(4300, 12864);
                Script.Wait(chooser);

                chooser = rnd.Next(1, 4);
                string msg2do = "";
                if (chooser == 1)
                {
                    msg2do = "Take a diversion, don't let them follow you back to the lab.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Don't let those bikers follow you back to the lab!";
                }
                else if (chooser == 3)
                {
                    msg2do = "The Lost are on to you - kill them and protect the trailer.";
                }

                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            upgrademission22counter += 1;
            if (upgrademission22counter < 7)
            {
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade2ped11, upgrade2vehicle9, upgrade2vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
            }
        }

        public static void UpgradeMission3Follow()
        { //This is the most hacky horrible piece of code I've ever written god damn
            if (upgrademission3counter == 0)
            {
                upgrade3vehicle8.IsPositionFrozen = false;

                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped4, upgrade3vehicle4, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped5, upgrade3vehicle4, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped3, upgrade3vehicle4, 20000, 1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped1, upgrade3vehicle4, 20000, 2, 5, 16, 0);

                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped12, upgrade3vehicle8, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped11, upgrade3vehicle8, 20000, 0, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped13, upgrade3vehicle8, 20000, 1, 5, 16, 0);

                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped7, upgrade3vehicle2, 20000, -1, 5, 16, 0);
                Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped8, upgrade3vehicle3, 20000, -1, 5, 16, 0);
            }
            upgrademission3counter += 1;
            if (upgrademission3counter < 500)
            {
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade3ped4, upgrade3vehicle4, upgrade3vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade3ped7, upgrade3vehicle2, upgrade3vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade3ped8, upgrade3vehicle3, upgrade3vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);
                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade3ped12, upgrade3vehicle8, upgrade3vehicle1, -1, 250f, 1074528293, 20f, -1, 15000f);

                if (upgrade3ped7.IsJumpingOutOfVehicle)
                {
                    Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped7, upgrade3vehicle2, 20000, -1, 5, 16, 0);
                }
                if (upgrade3ped8.IsJumpingOutOfVehicle)
                {
                    Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped8, upgrade3vehicle3, 20000, -1, 5, 16, 0);
                }
                if (upgrade3ped12.IsJumpingOutOfVehicle)
                {
                    Function.Call(Hash.TASK_ENTER_VEHICLE, upgrade3ped12, upgrade3vehicle8, 20000, -1, 5, 16, 0);
                }
                Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, upgrade3ped4, 8388614);
                Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, upgrade3ped7, 8388614);
                Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, upgrade3ped8, 8388614);
                Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, upgrade3ped12, 8388614);
            }
        }

        //Scene delete----------
        public static void deleteSceneUpgrade(int upgradeid)
        {
            try
            {
                foreach (Prop currentprop in getUpgradeProps())
                {
                    if (currentprop != null && currentprop.Exists())
                    {
                        currentprop.Delete();
                    }
                }
                foreach (Vehicle currentvehicle in getUpgradeVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists())
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }
            catch { GTA.UI.Notification.Show("~r~Error deleting upgrade scene ID=" + upgradeid.ToString()); }
        }

        public static void deleteSceneSupply(int supplyid)
        {
            try
            {
                foreach (Prop currentprop in getSupplyProps())
                {
                    if (currentprop != null && currentprop.Exists())
                    {
                        currentprop.Delete();
                    }
                }
                foreach (Vehicle currentvehicle in getSupplyVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists())
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getSupplyPeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }
            catch { GTA.UI.Notification.Show("~r~Error deleting supply scene ID=" + supplyid.ToString()); }
        }

        public static void deleteScene(int customerid)
        {
            try
            {
                foreach (Vehicle currentvehicle in getDealVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists())
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getDealPeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }
            catch { GTA.UI.Notification.Show("~r~Error deleting customer scene ID=" + customerid.ToString()); }
        }
        //-----------------------
        public static void QuitAnyCurrent()
        {
            if (OnDeal == 1)
            {
                Random rnd = new Random();
                int chooser = rnd.Next(1, 6);
                string msg2do = "";
                if (chooser == 1)
                {
                    msg2do = "Deals been called off, I've let the buyer know.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Just cancelled that deal for you.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Cancelled the deal, told them you're all out.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Cancelled that deal - think it might have been a set up anyway..";
                }
                else if (chooser == 5)
                {
                    msg2do = "I've told that meth head the deal is off.";
                }

                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                Meth.QuitDeal();
            }

            if (OnUpgrade == 1)
            {
                Random rnd = new Random();
                int chooser = rnd.Next(1, 4);
                string msg2do = "";
                if (chooser == 1)
                {
                    msg2do = "The jobs been called off, I've let all my guys know.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Really? I've cancelled that upgrade job for you.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Cancelled that job - we can cook just fine without the upgrade anyway..";
                }

                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                Meth.QuitUpgrade();
            }

            if (OnSupply == 1)
            {
                Random rnd = new Random();
                int chooser = rnd.Next(1, 6);
                string msg2do = "";
                if (chooser == 1)
                {
                    msg2do = "Deals been called off, I've let the seller know.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Just cancelled that deal for you.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Cancelled the deal, told them you've changed your mind.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Cancelled that deal - think it might have been a set up anyway..";
                }
                else if (chooser == 5)
                {
                    msg2do = "I've told the supplier the deal is off.";
                }

                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                Meth.QuitSupply();
            }
        }

        public static void QuitUpgrade()
        {
            if (Meth.OnUpgrade == 1)
            {
                try
                {
                    Game.Player.Money -= upgradePrice;
                    Meth.OnUpgrade = 0;
                    deleteSceneUpgrade(UpgradeMission);
                    bl.Delete();
                }
                catch { }
            }
        }

        public static Blip MethLabBlip;
        public static void DrawLabBlips()
        {
            if (MethLabBlip != null)
            {
                MethLabBlip.Delete();
            }
            MethLabBlip = World.CreateBlip(Meth.Lab_LiquorAce);
            MethLabBlip.Sprite = BlipSprite.Meth;
            MethLabBlip.Color = BlipColor.Red;
            MethLabBlip.IsShortRange = true;
            MethLabBlip.Name = "Meth Lab";
        }

        public static void QuitDeal()
        {
            try
            {
                if (Meth.OnDeal == 1)
                {
                    foreach (Ped currentped in getDealPeds())
                    {
                        if (currentped != null && currentped.AttachedBlip != null)
                        {
                            currentped.AttachedBlip.Delete();
                        }
                    }
                    Meth.OnDeal = 0;
                }
            }
            catch { }
        }

        public static void QuitSupply()
        {
            try
            {
                if (Meth.OnSupply == 1)
                {
                    Game.Player.Money += currentSupplyDeal * (Convert.ToInt32(Math.Ceiling(Convert.ToDouble(supplyPrice) / perk2supplymultiplier)));
                    Meth.OnSupply = 0;
                    deleteSceneSupply(Supplier);
                    bl.Delete();
                    foreach (Ped currentped in getSupplyPeds())
                    {
                        if (currentped != null && currentped.AttachedBlip != null)
                        {
                            currentped.AttachedBlip.Delete();
                        }
                    }
                }
            }
            catch { }

        }

        public static void cleanUp()
        {
            try
            {
                //Upgrade scenes
                foreach (Prop currentprop in getUpgradeProps())
                {
                    if (currentprop != null && currentprop.Exists() && currentprop.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentprop.Position) > 200f)
                    {
                        currentprop.Delete();
                    }
                }
                foreach (Vehicle currentvehicle in getUpgradeVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 200f)
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 200f)
                    {
                        currentped.Delete();
                    }
                }
                //Supply scenes
                foreach (Prop currentprop in getSupplyProps())
                {
                    if (currentprop != null && currentprop.Exists() && currentprop.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentprop.Position) > 200f)
                    {
                        currentprop.Delete();
                    }
                }
                foreach (Vehicle currentvehicle in getSupplyVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 200f)
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getSupplyPeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 200f)
                    {
                        currentped.Delete();
                    }
                }
                //Deal scenes
                foreach (Vehicle currentvehicle in getDealVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 200f)
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getDealPeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 200f)
                    {
                        currentped.Delete();
                    }
                }
                //Raid peds
                foreach (Ped currentped in getRaidPeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 120f)
                    {
                        currentped.Delete();
                    }
                }
                //Police sting scenes
                foreach (Vehicle currentvehicle in getSetupVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 130f)
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getSetupPeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 130f)
                    {
                        currentped.Delete();
                    }
                }
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Meth Dealing ~w~-~r~ error cleaning up scenes");
            }
        }

        public static void TextNotification(string avatar, string author, string title, string message)
        {
            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CONFIRM_BEEP", "HUD_MINI_GAME_SOUNDSET");
            Function.Call(Hash.BEGIN_TEXT_COMMAND_THEFEED_POST, new InputArgument[]
            {
            "STRING"
            });
            Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, new InputArgument[]
            {
            message
            });
            int CurrentNotification = Function.Call<int>(Hash.END_TEXT_COMMAND_THEFEED_POST_MESSAGETEXT, new InputArgument[]
            {
            avatar,
            avatar,
            true,
            0,
            title,
            author
            });
        }

        void DisplayHelpTextThisFrame(string text)
        {
            Function.Call(Hash.BEGIN_TEXT_COMMAND_DISPLAY_HELP, "STRING");
            Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);
            Function.Call(Hash.END_TEXT_COMMAND_DISPLAY_HELP, 0, 0, 1, -1);
        }

        public void onTick(object sender, EventArgs e)
        {
            if (getSuppliesItem != null)
            {
                getSuppliesItem.Description = SuppliesAmt[getSuppliesItem.SelectedIndex]+"x supply costs ~g~$" + (SuppliesAmt[getSuppliesItem.SelectedIndex] * supplyPrice).ToString();
            }
            if (_menuPool != null)
            {
                _menuPool.Process();
            }
            #region OnKey
            if (Game.IsControlJustPressed( (GTA.Control)quit_key))//E
            {
                if (quit_key_toggle == 1)
                {
                    GTA.UI.Notification.Show(quit_key_toggle.ToString());
                    QuitAnyCurrent();
                }
            }

            if (Game.IsControlJustPressed( (GTA.Control)activate_key))//E
            {
                if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) < 1.5 && !_menuPool.AreAnyVisible)
                {
                    if (OnLabraid == 0)
                    {
                        mainMenu.Visible = !mainMenu.Visible;
                    }
                    else
                    {
                        Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                        GTA.UI.Notification.Show("~r~There is a raid on your lab. Kill the raiders first.");
                    }
                }

                if (Meth.OnSupply == 1)
                {
                    if (Meth.Supplier == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.supply1location) < 1.5)
                        {
                            Meth.supply1crate.AttachedBlip.Delete();
                            Meth.supply1crate.Delete();
                            pickupSupplies();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, supply1ped1, "GENERIC_THANKS", "G_M_Y_STREETPUNK02_BLACK_MINI_04", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    else if (Meth.Supplier == 2)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.supply2location) < 1.5)
                        {
                            Meth.supply2crate.AttachedBlip.Delete();
                            Meth.supply2crate.Delete();
                            pickupSupplies();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, supply1ped2, "GENERIC_THANKS", "A_M_M_HillBilly_02_WHITE_MINI_02", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                }

                if (Meth.OnDeal == 1)
                {
                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 3);

                    string voiceid;
                    if (chooser == 1)
                    {
                        voiceid = "CHAT_STATE";
                    }
                    else
                    {
                        voiceid = "GENERIC_THANKS";
                    }

                    if (Meth.Customer == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal1location) < 1.5f)
                        {
                            Meth.deal1ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal1ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_03", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 2)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal2location) < 1.5f)
                        {
                            Meth.deal2ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal2ped1, voiceid, "A_M_M_TRAMP_01_BLACK_MINI_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 3)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal3location) < 1.5f)
                        {
                            Meth.deal3ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal3ped1, voiceid, "A_F_Y_EastSA_03_Latino_FULL_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 4)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal4location) < 1.5f)
                        {
                            Meth.deal4ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal4ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_03", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 5)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal5location) < 1.5f)
                        {
                            Meth.deal5ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal5ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_03", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 6)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal6location) < 1.5f)
                        {
                            Meth.deal6ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal6ped1, voiceid, "A_M_M_TRAMP_01_BLACK_MINI_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 7)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal7location) < 1.5f)
                        {
                            Meth.deal7ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal7ped1, voiceid, "A_M_Y_BeachVesp_01_White_Mini_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 8)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal8location) < 1.5f)
                        {
                            Meth.deal8ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal8ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_04", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 9)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal9location) < 1.5f)
                        {
                            Meth.deal9ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal9ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_03", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 10)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal10location) < 1.5f)
                        {
                            Meth.deal10ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal10ped1, voiceid, "A_M_M_HILLBILLY_02_WHITE_MINI_04", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 11)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal11location) < 1.5f)
                        {
                            Meth.deal11ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal11ped1, voiceid, "S_F_M_FEMBARBER_BLACK_MINI_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 12)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal12location) < 1.5f)
                        {
                            Meth.deal12ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal12ped1, voiceid, "G_M_Y_LOST_03_WHITE_FULL_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 13)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal13location) < 1.5f)
                        {
                            Meth.deal13ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal13ped1, voiceid, "A_M_M_HillBilly_02_WHITE_MINI_02", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 14)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal14location) < 1.5f)
                        {
                            Meth.deal14ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal14ped1, voiceid, "G_M_M_ARMLIEUT_01_WHITE_ARMENIAN_MINI_01", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                    if (Meth.Customer == 15)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.deal15location) < 1.5f)
                        {
                            Meth.deal15ped1.AttachedBlip.Delete();
                            sellToCustomer();
                            GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, deal15ped1, voiceid, "A_M_M_HillBilly_02_WHITE_MINI_02", "SPEECH_PARAMS_FORCE_SHOUTED", 0);
                        }
                    }
                }

                //Upgrade mission 8 - drop crates from heli
                if (OnUpgrade == 1 && UpgradeMission == 8)
                {
                    if (Game.Player.Character.CurrentVehicle != null && Game.Player.Character.CurrentVehicle.Model.Hash == 744705981 && Game.Player.Character.IsInVehicle(upgrade8vehicle1) && Game.GameTime > upgrade8dropwait)
                    {
                        upgrade8dropwait = Game.GameTime + 8000;

                        Vector3 rot = new GTA.Math.Vector3(0f, 0f, 0f);
                        Model model = new Model(-1319782883);
                        model.Request(10000);
                        Vector3 cratepos1 = new GTA.Math.Vector3(Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z - 2);
                        upgrade8crate1 = GTA.World.CreateProp(model, cratepos1, rot, false, false);
                        upgrade8crates.Add(upgrade8crate1);
                        upgrade8crate1.SetNoCollision(GTA.Game.Player.Character, true);
                        upgrade8crate1.SetNoCollision(upgrade8vehicle1, true);

                        upgrade8crate1.IsPositionFrozen = false;

                        Vector3 forcedirect = new GTA.Math.Vector3(0, 0, -1);
                        Vector3 forcerot = new GTA.Math.Vector3(0, 0, 0);

                        upgrade8crate1.ApplyForce(forcedirect, forcerot, ForceType.ForceNoRot);
                    }
                }
            }

            if (Game.IsControlJustPressed( (GTA.Control)anywhere_key))//E
            {

                if (OnLabraid == 0)
                {
                    mainMenu.Visible = !mainMenu.Visible;
                }
                else
                {
                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "OTHER_TEXT", "HUD_AWARDS");
                    GTA.UI.Notification.Show("~r~There is a raid on your lab. Kill the raiders first.");
                }
            }
            #endregion
            Meth.ResetCookingCooldown();
            Meth.autoBatchTimer();
            Meth.killerhashTimer();

            scaleformmsg();

            if (OnDeal == 0 && OnSupply == 0 && OnUpgrade == 0 && OnLabraid == 0)
            {
                cleanUp();
            }

            if (perk7hirecooks)
            {
                //Super hacky solution to the script not ticking every milisecond and instead being 0-20ms out approx
                if (Game.GameTime % perk7interval > 0 && Game.GameTime % perk7interval < 17 && Game.GameTime!=0)
                {
                    currentSupplies = currentSupplies - 10;
                    Random rnd = new Random();
                    int batchgrams = rnd.Next(cookLargeGramsMin * 5, cookLargeGramsMax * 5 + 1);
                    currentGrams = currentGrams + batchgrams;
                    saveStats();
                    GTA.UI.Notification.Show("Your cooks have finished a large batch! This cook produced ~g~" + batchgrams.ToString() + "g ~w~of ~r~meth.");
                    GTA.UI.Notification.Show("~g~Your cooks have started cooking another large batch!~w~ Meth will be ready shortly.");
                }
            }

            if (upgradeProps==1)
            {
                if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) < 50f && Game.GameTime > 5000)
                {
                    if (upgradePropStatus == 0)
                    {
                        upgradeLabPropSpawn();
                        perk7CookSpawn();
                        upgradePropStatus = 1;
                    }
                }
                else
                {
                    if (upgradePropStatus == 1)
                    {
                        upgradeLabPropDelete();
                        perk7CookDelete();
                        upgradePropStatus = 0;
                    }
                }
            }

            if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) < 1.5f && !_menuPool.AreAnyVisible == true)
            {
                DisplayHelpTextThisFrame("Hit " + ReturnButtonString(activate_key) + " to manage your ~r~Meth Business.");
            }
            if (Game.Player.Character.Position.DistanceTo(Meth.deal1location) < 1.5f || Game.Player.Character.Position.DistanceTo(Meth.deal2location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal3location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal4location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal5location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal6location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal7location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal8location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal9location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal10location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal11location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal12location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal13location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal14location) < 1.5 || Game.Player.Character.Position.DistanceTo(Meth.deal15location) < 1.5)
            {
                if (Meth.OnDeal == 1)
                {
                    DisplayHelpTextThisFrame("Hit " + ReturnButtonString(activate_key) + " to sell " + currentDealGrams + "g of meth for ~g~$" + ((currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier)))).ToString() + ".");
                }
            }
            if (Game.Player.Character.Position.DistanceTo(Meth.supply1location) < 1.5f || Game.Player.Character.Position.DistanceTo(Meth.supply2location) < 1.5f)
            {
                if (Meth.OnSupply == 1)
                {
                    DisplayHelpTextThisFrame("Hit " + ReturnButtonString(activate_key) + " to pick up the ~b~supplies.");
                }
            }
            if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) < 10f && perk5securityintel == false)
            {
                Random rnd = new Random();
                int chooser = rnd.Next(1, labRaidFreq);
                if (chooser == 1 && OnLabraid == 0)
                {
                    if (labRaidToggle == 1 && Game.GameTime > labraidCooldown)
                    {
                        triggerLabRaid();
                    }
                }
            }
            if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce_doors) < 5f || Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) < 10f)
            {

                Prop door1 = Function.Call<Prop>(Hash.GET_CLOSEST_OBJECT_OF_TYPE, 1392.9269f, 3599.4688, 35.1308f, 1f, -1212951353, false, false, false);
                Prop door2 = Function.Call<Prop>(Hash.GET_CLOSEST_OBJECT_OF_TYPE, 1395.3710f, 3600.3584f, 35.1308f, 1f, -1212951353, false, false, false);
                door1.IsPositionFrozen = false;
                door2.IsPositionFrozen = false;
            }

            if (OnLabraid == 1)
            {
                OnLabraid = 0;
                Game.Player.WantedLevel = 0;

                foreach (Ped currentped in getRaidPeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsAlive == true)
                    {
                        OnLabraid = 1;
                        if (currentped.Position.DistanceTo(Lab_LiquorAce) > 150f)
                        {
                            currentped.Kill();
                        }
                        if (currentped.IsInCombat == false)
                        {
                            currentped.Task.FightAgainstHatedTargets(50f, 100);
                            currentped.Task.FightAgainst(Game.Player.Character);
                            currentped.Weapons.Give(WeaponHash.Pistol, 100, false, false);
                        }
                    }
                    if (currentped != null && currentped.Exists() && currentped.IsAlive == false && currentped.AttachedBlip != null)
                    {
                        currentped.AttachedBlip.Delete();
                    }
                }

                if (OnLabraid == 1 && GTA.Game.Player.Character.IsAlive == false)
                {
                    failLabRaid();
                }

                if (OnLabraid == 0 && labraidfailed == 0)
                {
                    finishLabRaid();
                }

                GTA.UI.Screen.ShowSubtitle("Kill the ~r~raiders~w~ to protect your meth stash.", 1);
            }

            if (OnSupply == 1)
            {
                if (supplyNeverWanted==1 && Game.Player.WantedLevel != 0)
                {
                    Game.Player.WantedLevel = 0;
                }
                if (Supplier == 100)
                {
                    if (supply100vehicle1.IsDead || supply100vehicle1.IsDriveable == false)
                    {
                        failBulkSupply(Supplier);
                    }
                    if (supply100_p1 == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.supply100_marker1) < 1.5)
                        {
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Drive the van back to the meth lab.");
                            supply100ped1.Task.PlayAnimation("oddjobs@hunter", "point_fwd", 8f, -1, AnimationFlags.UpperBodyOnly);
                            supply100_p1 = 0;
                            supply100_p2 = 1;
                            Meth.supply100ped1.AttachedBlip.Delete();
                            Meth.supply100vehicle1.AddBlip();
                            supply100vehicle1.AttachedBlip.Sprite = BlipSprite.PersonalVehicleCar;
                            supply100vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            Meth.supply100vehicle1.AttachedBlip.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~b~supplies.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply100_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply100_p2 == 1)
                    {
                        if (Game.Player.Character.CurrentVehicle == supply100vehicle1)
                        {
                            supply100_p2 = 0;
                            supply100_p3 = 1;
                            Meth.supply100vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(supply100_marker3, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Get in the ~b~van.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply100_marker2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply100_p3 == 1)
                    {
                        if (supply100vehicle1.Position.DistanceTo(Meth.supply100_marker3) < 2f)
                        {
                            Meth.bl.Delete();
                            supply100_p3 = 0;
                            supply100vehicle1.IsDriveable = false;
                            finishBulkSupply(Supplier);
                        }
                        GTA.UI.Screen.ShowSubtitle("Drive the ~b~van~w~ back to the ~r~meth lab.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply100_marker3, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                    }
                }
                if (Supplier == 101)
                {
                    if (supply101vehicle1.IsDead || supply101vehicle1.IsDriveable == false)
                    {
                        failBulkSupply(Supplier);
                    }
                    if (supply101_p1 == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.supply101_marker1) < 1.5)
                        {
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Drive the van back to the meth lab.");
                            supply101ped1.Task.PlayAnimation("oddjobs@hunter", "point_fwd", 8f, -1, AnimationFlags.UpperBodyOnly);
                            supply101_p1 = 0;
                            supply101_p2 = 1;
                            Meth.supply101ped1.AttachedBlip.Delete();
                            Meth.supply101vehicle1.AddBlip();
                            supply101vehicle1.AttachedBlip.Sprite = BlipSprite.PersonalVehicleCar;
                            supply101vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            Meth.supply101vehicle1.AttachedBlip.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~b~supplies.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply101_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply101_p2 == 1)
                    {
                        if (Game.Player.Character.CurrentVehicle == supply101vehicle1)
                        {
                            supply101_p2 = 0;
                            supply101_p3 = 1;
                            Meth.supply101vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(supply101_marker3, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Get in the ~b~van.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply101_marker2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply101_p3 == 1)
                    {
                        if (supply101vehicle1.Position.DistanceTo(Meth.supply101_marker3) < 5f)
                        {
                            Meth.bl.Delete();
                            supply101_p3 = 0;
                            supply101vehicle1.IsDriveable = false;
                            finishBulkSupply(101);
                        }
                        GTA.UI.Screen.ShowSubtitle("Drive the ~b~van~w~ back to the ~r~meth lab.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply101_marker3, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                    }
                }
                if (Supplier == 102)
                {
                    if (supply102vehicle1.IsDead || supply102vehicle1.IsDriveable == false)
                    {
                        failBulkSupply(Supplier);
                    }
                    if (supply102_part == 1)
                    {
                        if (supply102vehicle1 != null && Game.Player.Character.Position.DistanceTo(supply102vehicle1.Position)<40f)
                        {
                            Random rnd = new Random();
                            int chooser = rnd.Next(1, 6);
                            string msg2do = "";
                            if (chooser == 1)
                            {
                                msg2do = "You found it? Get in and drive it back to the lab.";
                            }
                            if (chooser == 2)
                            {
                                msg2do = "Took your time.. Now jump in and drive back to the lab.";
                            }
                            if (chooser == 3)
                            {
                                msg2do = "Just jump in and drive it back to the lab.";
                            }
                            if (chooser == 4)
                            {
                                msg2do = "Now you've found it, hop in and drive it back to the lab.";
                            }
                            if (chooser == 5)
                            {
                                msg2do = "Now get in to the van and drive it back to the lab. ASAP!";
                            }
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                            supply102_part = 2;
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~b~supplies.", 1);
                    }
                    if (supply102_part == 2)
                    {
                        if (supply102vehicle1 != null && Game.Player.Character.CurrentVehicle == supply102vehicle1)
                        {
                            supply102_part = 3;
                            Meth.supply102vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(supply102_marker1, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Get in the ~b~Mule.", 1);
                    }
                    if (supply102_part == 3)
                    {
                        if (supply102vehicle1.Position.DistanceTo(Meth.supply102_marker1) < 5f)
                        {
                            Meth.bl.Delete();
                            supply102_part = 0;
                            supply102vehicle1.IsDriveable = false;
                            finishBulkSupply(Supplier);
                        }
                        GTA.UI.Screen.ShowSubtitle("Drive the ~b~van~w~ back to the ~r~meth lab.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply102_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                    }
                }
                if (Supplier == 103)
                {
                    if (supply103vehicle1.IsDead || supply103vehicle1.IsDriveable == false)
                    {
                        failBulkSupply(Supplier);
                    }
                    if (supply103_part == 1)
                    {
                        if (supply103vehicle1 != null && Game.Player.Character.Position.DistanceTo(supply103vehicle1.Position) < 40f)
                        {
                            Random rnd = new Random();
                            int chooser = rnd.Next(1, 6);
                            string msg2do = "";
                            if (chooser == 1)
                            {
                                msg2do = "You found it? Connect to the trailer and bring it back to the lab.";
                            }
                            if (chooser == 2)
                            {
                                msg2do = "Took your time.. Now attach to the trailer and drive back to the lab.";
                            }
                            if (chooser == 3)
                            {
                                msg2do = "Just attach to the trailer and drive it back to the lab.";
                            }
                            if (chooser == 4)
                            {
                                msg2do = "Now you've found it, attach to the traier and transport it back to the lab.";
                            }
                            if (chooser == 5)
                            {
                                msg2do = "Speed it up! Attach to that trailer and get it back to the lab.";
                            }
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                            if (supply103vehicle2.Exists() && supply103vehicle2.AttachedBlip.Exists())
                            {
                                supply103vehicle2.AttachedBlip.Delete();
                            }
                            if (supply103vehicle3.Exists() && supply103vehicle3.AttachedBlip.Exists())
                            {
                                supply103vehicle3.AttachedBlip.Delete();
                            }

                            supply103_part = 2;
                        }
                        if (Game.Player.Character.IsInVehicle(supply103vehicle2) && Game.Player.Character.CurrentVehicle.AttachedBlip.Exists())
                        {
                            supply103vehicle2.AttachedBlip.Delete();
                            supply103vehicle3.AttachedBlip.Delete();
                        }
                        if (Game.Player.Character.IsInVehicle(supply103vehicle3) && Game.Player.Character.CurrentVehicle.AttachedBlip.Exists())
                        {
                            supply103vehicle2.AttachedBlip.Delete();
                            supply103vehicle3.AttachedBlip.Delete();
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~b~supplies.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply101_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply103_part == 2)
                    {
                        if (Game.Player.Character.IsInVehicle())
                        {                           
                            if (supply103vehicle1 != null && GetTrailerVehicle(Game.Player.Character.CurrentVehicle) == supply103vehicle1)
                            {
                                if (bl == null)
                                {
                                    bl = World.CreateBlip(supply103_marker1, 3f);
                                    bl.Sprite = BlipSprite.RaceFinish;
                                    bl.Color = BlipColor.Red;
                                    bl.ShowRoute = true;
                                }
                                if (supply103vehicle1.Position.DistanceTo(Meth.supply103_marker1) < 5f)
                                {
                                    Meth.supply103vehicle1.AttachedBlip.Delete();
                                    Meth.bl.Delete();
                                    supply103_part = 0;
                                    if (supply103vehicle2.Exists())
                                    {
                                        supply103vehicle2.IsDriveable = false;
                                    }
                                    if (supply103vehicle3.Exists())
                                    {
                                        supply103vehicle3.IsDriveable = false;
                                    }
                                    finishBulkSupply(Supplier);
                                }
                                GTA.UI.Screen.ShowSubtitle("Drive the ~b~trailer~w~ back to the ~r~meth lab.", 1);
                                World.DrawMarker(MarkerType.VerticalCylinder, supply103_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                            }
                            else
                            {
                                GTA.UI.Screen.ShowSubtitle("Attach to the ~b~trailer.", 1);
                                if (bl != null && bl.Exists())
                                {
                                    bl.Delete();
                                    bl = null;
                                }
                            }
                        }            
                        else
                        {
                            GTA.UI.Screen.ShowSubtitle("Find a vehicle to transport the ~b~trailer.", 1);
                        }                        
                    }
                }
                if (Supplier == 104)
                {
                    if (supply104vehicle1.IsDead || supply104vehicle1.IsDriveable == false)
                    {
                        failBulkSupply(Supplier);
                    }
                    if (supply104_part == 1)
                    {
                        if (supply104vehicle1 != null && Game.Player.Character.Position.DistanceTo(supply104vehicle1.Position) < 40f)
                        {
                            Random rnd = new Random();
                            int chooser = rnd.Next(1, 6);
                            string msg2do = "";
                            if (chooser == 1)
                            {
                                msg2do = "You found it? Hop in and fly back over to the lab!";
                            }
                            if (chooser == 2)
                            {
                                msg2do = "Guess you found it - jump in and fly back to the lab.";
                            }
                            if (chooser == 3)
                            {
                                msg2do = "About time! Now fly back here! We need to get another batch cooking.";
                            }
                            if (chooser == 4)
                            {
                                msg2do = "Took your time.. Get back to the lab, we need to get cooking!";
                            }
                            if (chooser == 5)
                            {
                                msg2do = "Great - now just fly it back to the lab. Careful not to crash in to anything!";
                            }
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                            supply104_part = 2;
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~b~supplies.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, supply101_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.LightBlue);
                    }
                    if (supply104_part == 2)
                    {
                        if (Game.Player.Character.IsInHeli && Game.Player.Character.CurrentVehicle == supply104vehicle1)
                        {
                            World.DrawMarker(MarkerType.VerticalCylinder, supply104_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                            GTA.UI.Screen.ShowSubtitle("Fly the ~b~Maverick~w~ back to the ~r~meth lab.", 1);
                            if (supply104vehicle1.AttachedBlip.Exists() == false)
                            {
                                supply104vehicle1.AddBlip();
                                supply104vehicle1.AttachedBlip.Sprite = BlipSprite.HelicopterAnimated;
                                supply104vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            }
                            else if (supply104vehicle1.AttachedBlip.Exists() && supply104vehicle1.AttachedBlip.Sprite == BlipSprite.Helicopter)
                            {
                                supply104vehicle1.AttachedBlip.Sprite = BlipSprite.HelicopterAnimated;
                                supply104vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            }
                        }
                        else
                        {
                            GTA.UI.Screen.ShowSubtitle("Get in the ~b~Maverick.", 1);
                            if (supply104vehicle1.AttachedBlip == null || supply104vehicle1.AttachedBlip.Exists() == false)
                            {
                                supply104vehicle1.AddBlip();
                                supply104vehicle1.AttachedBlip.Sprite = BlipSprite.Helicopter;
                                supply104vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            }
                            else
                            {
                                supply104vehicle1.AttachedBlip.Sprite = BlipSprite.Helicopter;
                                supply104vehicle1.AttachedBlip.Color = BlipColor.Blue;
                            }
                        }
                        if (supply104vehicle1.Position.DistanceTo(Meth.supply104_marker1) < 5f)
                        {
                            Meth.supply104vehicle1.AttachedBlip.Delete();
                            supply104_part = 0;
                            finishBulkSupply(Supplier);
                        }
                    }
                }
            }

            if (OnUpgrade == 1)
            {
                if (upgradeNeverWanted == 1 && Game.Player.WantedLevel != 0)
                {
                    Game.Player.WantedLevel = 0;
                }
                if (UpgradeMission == 1)
                {
                    if (upgrade1vehicle1.IsDead || upgrade1vehicle1.IsDriveable != true || GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade1_part == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade1_marker1) < 5)
                        {
                            upgrade1_part = 2;
                            Meth.upgrade1vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(upgrade1_marker2, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                            turnHostileUpgrade();
                            upgrademission1counter = 0;
                        }
                        GTA.UI.Screen.ShowSubtitle("Steal the ~g~Sandking.", 150);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade1_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.Green);
                    }
                    if (upgrade1_part == 2)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade1_marker2) < 4)
                        {
                            upgrade1_part = 0;
                            finishUpgradeMission(UpgradeMission);
                        }
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade1_marker1) >= 10)
                        {
                            UpgradeMission1Follow();
                        }
                        GTA.UI.Screen.ShowSubtitle("Deliver the ~g~Sandking~w~ to your ~r~lab.", 150);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade1_marker2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);

                    }
                }

                if (UpgradeMission == 2)
                {
                    if (upgrade2vehicle1.IsDead || GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade2_part == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade2_marker1) < 7)
                        {
                            upgrade2_part = 2;
                            Meth.upgrade2vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(upgrade2_marker2, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                            turnHostileUpgrade();
                            upgrademission2counter = 0;
                        }
                        GTA.UI.Screen.ShowSubtitle("Steal the ~g~trailer.", 150);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade2_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(2.0f, 2.0f, 2.0f), System.Drawing.Color.Green);
                    }
                    if (upgrade2_part == 2)
                    {
                        if (upgrade2vehicle1.Position.DistanceTo(Meth.upgrade2_marker2) < 8)
                        {
                            finishUpgradeMission(UpgradeMission);
                        }
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade2_marker1) >= 10)
                        {
                            UpgradeMission2Follow();
                        }
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade2vehicle8.Position) <= 20)
                        {
                            UpgradeMission21Follow();
                        }
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade2vehicle9.Position) <= 20)
                        {
                            UpgradeMission22Follow();
                        }
                        if (upgrade2vehicle1.Rotation.Y < -55 || upgrade2vehicle1.Rotation.Y > 55)
                        {
                            upgrade2vehicle1.Rotation = new Vector3(upgrade2vehicle1.Rotation.X, 0.0f, upgrade2vehicle1.Rotation.Z);
                        }

                        GTA.UI.Screen.ShowSubtitle("Deliver the ~g~trailer~w~ to your ~r~lab.", 150);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade2_marker2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(2.0f, 2.0f, 2.0f), System.Drawing.Color.Red);

                    }
                }

                if (UpgradeMission == 3)
                {
                    if (upgrade3vehicle1.IsDead || upgrade3vehicle1.IsDriveable != true || GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade3_part == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade3_marker1) < 4)
                        {
                            upgrade3_part = 2;
                            Meth.upgrade3vehicle1.AttachedBlip.Delete();
                            bl = World.CreateBlip(upgrade3_marker2, 3f);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                            turnHostileUpgrade();
                            upgrademission3counter = 0;
                        }
                        GTA.UI.Screen.ShowSubtitle("Steal the ~g~Blazer.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade3_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.Green);

                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade3_marker1) < 20)
                        {
                            Random rnd = new Random();
                            int chooser = rnd.Next(1, 2500);
                            if (chooser == 1)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "GENERIC_HI", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 2)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "GENERIC_THANKS", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 3)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "GENERIC_HOWS_IT_GOING", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 4)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "CHAT_RESP", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 5)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "CHAT_STATE", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 6)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "NICE_CAR_THANKS", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 7)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "PHONE_CONV1_CHAT1", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 8)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "PHONE_CONV4_CHAT2", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 9)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "SUSPECT_KILLED", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 10)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "PHONE_CONV1_CHAT2", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 11)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "PHONE_CONV3_CHAT1", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 12)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped2, "PHONE_CONV4_CHAT1", "G_M_M_MEXBOSS_02_LATINO_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            chooser = rnd.Next(1, 2500);
                            if (chooser == 1)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "GENERIC_HI", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 2)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "GENERIC_THANKS", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 3)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "GENERIC_HOWS_IT_GOING", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 4)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "CHAT_RESP", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 5)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "CHAT_STATE", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 6)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "NICE_CAR_THANKS", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 7)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "PHONE_CONV1_CHAT1", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 8)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "PHONE_CONV4_CHAT2", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 9)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "SUSPECT_KILLED", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 10)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "PHONE_CONV1_CHAT2", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 11)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "PHONE_CONV3_CHAT2", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                            else if (chooser == 12)
                            {
                                GTA.Native.Function.Call(Hash._PLAY_AMBIENT_SPEECH_WITH_VOICE, upgrade3ped6, "PHONE_CONV4_CHAT1", "G_M_Y_SALVABOSS_01_SALVADORIAN_MINI_01", "SPEECH_PARAMS_FORCE", 0);
                            }
                        }

                    }
                    if (upgrade3_part == 2)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade3_marker2) < 4)
                        {
                            finishUpgradeMission(UpgradeMission);
                        }
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade3_marker1) >= 15)
                        {
                            UpgradeMission3Follow();
                        }
                        GTA.UI.Screen.ShowSubtitle("Deliver the ~g~Blazer~w~ to your ~r~lab.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade3_marker2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(2.0f, 2.0f, 2.0f), System.Drawing.Color.Red);

                    }
                }

                if (UpgradeMission == 4)
                {
                    if (GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    foreach (Ped currentped in getUpgradePeds())
                    {
                        if (currentped != null && currentped.IsAlive == false && currentped.AttachedBlip.Exists())
                        {
                            currentped.AttachedBlip.Delete();
                        }
                    }

                    if (upgrade4_part == 1)
                    {
                        if (upgrade4ped1.IsAlive == false && upgrade4ped1.Exists())
                        {
                            upgrade4_part = 0;
                            Meth.upgrade4ped1.AttachedBlip.Delete();
                            turnHostileUpgrade();
                            finishUpgradeMission(4);
                        }

                        if (upgrade4ped1.IsFleeing || upgrade4ped1.IsOnScreen && Game.Player.Character.Position.DistanceTo(upgrade4ped1.Position) < 250f)
                        {
                            upgrade4_targetspot = upgrade4_targetspot + 1;
                        }
                        if (upgrade4_targetspot == 900)
                        {
                            turnHostileUpgrade();
                        }

                        if (upgrade4ped1.IsFleeing && upgrade4_targetspooked == 0)
                        {
                            Random rnd = new Random();
                            upgrade4_targetspooked = 1;

                            int chooser = rnd.Next(1, 4);
                            string msg2do = "";
                            if (chooser == 1)
                            {
                                msg2do = "You spooked the target! Take him out before it's too late.";
                            }
                            else if (chooser == 2)
                            {
                                msg2do = "Kill the target before they flee to safety!";
                            }
                            else if (chooser == 3)
                            {
                                msg2do = "Get a shot on him before the target is out of sight.";
                            }

                            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
                        }

                        if (upgrade4_targetspooked == 1 && Game.Player.Character.Position.DistanceTo(upgrade4ped1.Position) > 300f && upgrade4ped1.IsAlive && upgrade4ped1.IsOnScreen == false)
                        {
                            failUpgradeMission(4);
                        }

                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~target.", 1);
                        World.DrawMarker(MarkerType.UpsideDownCone, new Vector3(upgrade4ped1.Position.X, (upgrade4ped1.Position.Y), upgrade4ped1.Position.Z + 1.5f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.5f, 0.5f, 0.5f), System.Drawing.Color.Red);

                    }
                }

                if (UpgradeMission == 5)
                {
                    if (GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade5_part == 1)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade5crate1.Position) < 25)
                        {
                            upgrade5_part = 2;
                            Meth.upgrade5crate1.AttachedBlip.Delete();
                            turnHostileUpgrade();
                        }
                        GTA.UI.Screen.ShowSubtitle("Steal the ~g~crate.", 1);

                    }
                    if (upgrade5_part == 2)
                    {
                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~gang members.", 1);
                        if (upgrade5ped1.IsDead && upgrade5ped2.IsDead && upgrade5ped3.IsDead && upgrade5ped4.IsDead && upgrade5ped5.IsDead && upgrade5ped6.IsDead && upgrade5ped7.IsDead && upgrade5ped8.IsDead && upgrade5ped9.IsDead && upgrade5ped10.IsDead && upgrade5ped11.IsDead && upgrade5ped12.IsDead && upgrade5ped13.IsDead)
                        {
                            upgrade5_part = 3;
                        }
                    }
                    if (upgrade5_part == 3)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade5crate1.Position) < 1.5f)
                        {
                            upgrade5_part = 4;
                            upgrade5crate1.Delete();
                            Function.Call(Hash.ANIMPOSTFX_PLAY, "HeistCelebToast", 0, false);
                            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "PURCHASE", "HUD_LIQUOR_STORE_SOUNDSET");

                            bl = World.CreateBlip(upgrade5_marker1);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Red;
                            bl.ShowRoute = true;
                        }
                        if (upgrade5crate1.AttachedBlip.Exists() == false)
                        {
                            Meth.upgrade5crate1.AddBlip();
                            upgrade5crate1.AttachedBlip.Sprite = BlipSprite.SpecialCargo;
                            upgrade5crate1.AttachedBlip.Color = BlipColor.Green;
                            Meth.upgrade5crate1.AttachedBlip.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Pick up the ~g~crate.", 1);
                    }
                    if (upgrade5_part == 4)
                    {
                        if (Game.Player.Character.Position.DistanceTo(Meth.upgrade5_marker1) < 3)
                        {
                            upgrade5_part = 0;
                            finishUpgradeMission(5);
                        }
                        GTA.UI.Screen.ShowSubtitle("Deliver the ~g~crate~w~ back to the ~r~lab.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade5_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(1.0f, 1.0f, 1.0f), System.Drawing.Color.Red);
                    }
                }

                if (UpgradeMission == 6)
                {
                    if (GTA.Game.Player.IsAlive != true || upgrade6vehicle1.IsDriveable != true)
                    {
                        if (upgrade6vehicle1.AttachedBlip.Exists())
                        {
                            upgrade6vehicle1.AttachedBlip.Delete();
                        }
                        if (GTA.Game.Player.IsAlive != true)
                        {
                            scaleform_bottom = "You died during the mission.";
                        }
                        if (upgrade6vehicle1.IsDriveable != true)
                        {
                            scaleform_bottom = "The ~g~Hydra~w~ was destroyed.";
                        }
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade6_part == 1) //Get player in to Hydra
                    {
                        if (Game.Player.Character.IsInVehicle(upgrade6vehicle1))
                        {
                            upgrade6_part = 2;
                            Meth.upgrade6vehicle2 = GTA.World.CreateVehicle(new Model(-1745203402), new GTA.Math.Vector3(1948.743f, 4634.548f, 40.38613f), 104.4526f); //First blam vans
                            Meth.upgrade6vehicle3 = GTA.World.CreateVehicle(new Model(-1745203402), new GTA.Math.Vector3(1942.434f, 4642.946f, 40.44304f), -111.1778f); //First blam vans
                            upgrade6ped1 = GTA.World.CreatePed(new Model(32417469), new GTA.Math.Vector3(1946.133f, 4637.589f, 40.56693f), -117.0881f);
                            upgrade6ped2 = GTA.World.CreatePed(new Model(2119136831), new GTA.Math.Vector3(1947.532f, 4638.259f, 40.57524f), 169.8764f);
                            upgrade6ped3 = GTA.World.CreatePed(new Model(-1176698112), new GTA.Math.Vector3(1946.497f, 4636.374f, 40.54762f), -38.9992f);
                            upgrade6ped4 = GTA.World.CreatePed(new Model(-1463670378), new GTA.Math.Vector3(1941.803f, 4640.667f, 40.64164f), -164.6121f);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Great. There is a van switch going down at the location I've sent you.");
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "One of the vans is empty, the other contains meth. Blow them both up just to be sure!");
                            upgrade6vehicle2.AddBlip();
                            upgrade6vehicle2.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle2.AttachedBlip.Color = BlipColor.Red;
                            upgrade6vehicle3.AddBlip();
                            upgrade6vehicle3.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle3.AttachedBlip.Color = BlipColor.Red;

                        }
                        GTA.UI.Screen.ShowSubtitle("Get in the ~g~Hydra.", 1);

                    }
                    if (upgrade6_part == 2) //Get player to kill scene 1
                    {
                        if (upgrade6vehicle2.IsDriveable != true && upgrade6vehicle3.IsDriveable != true)
                        {
                            if (upgrade6vehicle2.AttachedBlip.Exists())
                            {
                                upgrade6vehicle2.AttachedBlip.Delete();
                            }
                            if (upgrade6vehicle3.AttachedBlip.Exists())
                            {
                                upgrade6vehicle3.AttachedBlip.Delete();
                            }
                            upgrade6_part = 3;
                            Meth.upgrade6vehicle4 = GTA.World.CreateVehicle(new Model(80636076), new GTA.Math.Vector3(2547.894f, 4680.112f, 33.19466f), -5.378663f);
                            Meth.upgrade6vehicle5 = GTA.World.CreateVehicle(new Model(65402552), new GTA.Math.Vector3(2561.425f, 4685.439f, 33.60718f), 101.3645f); //Second blam van
                            upgrade6ped5 = GTA.World.CreatePed(new Model(1822107721), new GTA.Math.Vector3(2567.556f, 4684.499f, 34.05129f), -6.697811f);
                            upgrade6ped6 = GTA.World.CreatePed(new Model(2064532783), new GTA.Math.Vector3(2567.56f, 4685.728f, 34.05129f), -166.8609f);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Good work. Now get to the next location - there's another van you need to take care of.");
                            upgrade6vehicle5.AddBlip();
                            upgrade6vehicle5.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle5.AttachedBlip.Color = BlipColor.Red;
                        }
                        if (upgrade6vehicle2.IsDriveable != true && upgrade6vehicle2.AttachedBlip.Exists())
                        {
                            upgrade6vehicle2.AttachedBlip.Delete();
                        }
                        if (upgrade6vehicle3.IsDriveable != true && upgrade6vehicle2.AttachedBlip.Exists())
                        {
                            upgrade6vehicle3.AttachedBlip.Delete();
                        }
                        GTA.UI.Screen.ShowSubtitle("Destroy the ~r~vans.", 1);
                    }
                    if (upgrade6_part == 3) //Get player to kill scene 2
                    {
                        if (upgrade6vehicle5.IsDriveable != true)
                        {
                            if (upgrade6vehicle5.AttachedBlip.Exists())
                            {
                                upgrade6vehicle5.AttachedBlip.Delete();
                            }
                            UpgradeMission6Cleanup();
                            upgrade6_part = 4;
                            Meth.upgrade6vehicle6 = GTA.World.CreateVehicle(new Model(-2140210194), new GTA.Math.Vector3(2917.972f, 4635.191f, 48.74606f), -48.54824f);
                            Meth.upgrade6vehicle7 = GTA.World.CreateVehicle(new Model(-2140210194), new GTA.Math.Vector3(2923.577f, 4631.33f, 48.73765f), -39.45861f);
                            Meth.upgrade6vehicle8 = GTA.World.CreateVehicle(new Model(1518533038), new GTA.Math.Vector3(2947.058f, 4641.889f, 48.77872f), -13.05195f);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Nice one, there's a few more trailers full of product that you need to destroy.");
                            upgrade6vehicle6.AddBlip();
                            upgrade6vehicle6.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle6.AttachedBlip.Color = BlipColor.Red;
                            upgrade6vehicle7.AddBlip();
                            upgrade6vehicle7.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle7.AttachedBlip.Color = BlipColor.Red;

                        }
                        GTA.UI.Screen.ShowSubtitle("Destroy the ~r~van.", 1);
                    }
                    if (upgrade6_part == 4) //Get player to kill scene 3
                    {
                        if (upgrade6vehicle6.IsDead && upgrade6vehicle7.IsDead)
                        {
                            if (upgrade6vehicle6.AttachedBlip.Exists())
                            {
                                upgrade6vehicle6.AttachedBlip.Delete();
                            }
                            if (upgrade6vehicle7.AttachedBlip.Exists())
                            {
                                upgrade6vehicle7.AttachedBlip.Delete();
                            }
                            UpgradeMission6Cleanup();
                            upgrade6_part = 5;
                            Meth.upgrade6vehicle9 = GTA.World.CreateVehicle(new Model(356391690), new GTA.Math.Vector3(2312.197f, 3230.673f, 47.00118f), 66.52007f);
                            upgrade6ped7 = GTA.World.CreatePed(new Model(1768677545), new GTA.Math.Vector3(2323.524f, 3228.144f, 47.8897f), -73.93405f);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "One last location, the home of a local meth head. It's being used to distribute product.");
                            upgrade6vehicle9.AddBlip();
                            upgrade6vehicle9.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade6vehicle9.AttachedBlip.Color = BlipColor.Red;
                        }
                        if (upgrade6vehicle6.IsDead && upgrade6vehicle6.AttachedBlip.Exists())
                        {
                            upgrade6vehicle6.AttachedBlip.Delete();
                        }
                        if (upgrade6vehicle7.IsDead && upgrade6vehicle7.AttachedBlip.Exists())
                        {
                            upgrade6vehicle7.AttachedBlip.Delete();
                        }
                        GTA.UI.Screen.ShowSubtitle("Destroy the ~r~trailers.", 1);
                    }
                    if (upgrade6_part == 5) //Get player to kill scene 4
                    {
                        if (upgrade6vehicle9.IsDead)
                        {
                            UpgradeMission6Cleanup();
                            upgrade6_part = 6;
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Perfect. Now fly back; careful not to damage the Hydra or I'll lose my deposit!");
                            if (upgrade6vehicle9.AttachedBlip.Exists())
                            {
                                upgrade6vehicle9.AttachedBlip.Delete();
                            }
                            bl = World.CreateBlip(upgrade6_marker1);
                            bl.Sprite = BlipSprite.RaceFinish;
                            bl.Color = BlipColor.Blue;
                            bl.ShowRoute = true;
                        }
                        GTA.UI.Screen.ShowSubtitle("Destroy the ~r~trailer.", 1);
                    }
                    if (upgrade6_part == 6) //Get player to fly back to airfield
                    {
                        if (upgrade6vehicle1.Position.DistanceTo(Meth.upgrade6_marker1) < 7f)
                        {
                            if (upgrade6vehicle1.AttachedBlip.Exists())
                            {
                                upgrade6vehicle1.AttachedBlip.Delete();
                            }
                            if (bl.Exists())
                            {
                                bl.Delete();
                            }
                            UpgradeMission6Cleanup();
                            upgrade6_part = 0;
                            finishUpgradeMission(6);
                            upgrade6vehicle1.IsDriveable = false;
                        }
                        GTA.UI.Screen.ShowSubtitle("Land the ~g~Hydra~w~ at the ~b~airfield.", 1);
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade6_marker1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(7.0f, 7.0f, 1.5f), System.Drawing.Color.LightBlue);
                    }
                }

                if (UpgradeMission == 7)
                {
                    World.DrawMarker(MarkerType.VerticalCylinder, upgrade7_markerhumane, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(7.0f, 7.0f, 1.5f), System.Drawing.Color.LightBlue);

                    if (GTA.Game.Player.IsAlive != true || upgrade7vehicle1.IsDriveable != true)
                    {
                        if (upgrade7vehicle1.AttachedBlip.Exists())
                        {
                            upgrade7vehicle1.AttachedBlip.Delete();
                        }
                        if (GTA.Game.Player.IsAlive != true)
                        {
                            scaleform_bottom = "You died during the mission.";
                        }
                        if (upgrade7vehicle1.IsDriveable != true)
                        {
                            scaleform_bottom = "The ~g~Boxville~w~ was destroyed.";
                        }
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade7vehicle1.Position.DistanceTo(Meth.upgrade7_markerhumane) < 40f) //Check if Boxville reached humane labs
                    {
                        scaleform_bottom = "The ~g~Boxville~w~ reached Humane Labs.";
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade7vehicle1.Position.DistanceTo(Meth.upgrade7_markerlab) < 5f) //Check if Boxville reached meth lab
                    {
                        finishUpgradeMission(UpgradeMission);
                    }

                    if (upgrade7_part == 1) //Get player to catch up with Boxville
                    {
                        if (Game.Player.Character.Position.DistanceTo(upgrade7vehicle1.Position) < 250f)
                        {
                            upgrade7ped1.Task.WarpIntoVehicle(upgrade7vehicle1, VehicleSeat.Driver);
                            upgrade7ped2.Task.WarpIntoVehicle(upgrade7vehicle1, VehicleSeat.Passenger);

                            upgrade7ped4.Task.WarpIntoVehicle(upgrade7vehicle2, VehicleSeat.Driver);
                            upgrade7ped3.Task.WarpIntoVehicle(upgrade7vehicle2, VehicleSeat.Passenger);

                            upgrade7ped5.Task.WarpIntoVehicle(upgrade7vehicle3, VehicleSeat.Driver);
                            upgrade7ped6.Task.WarpIntoVehicle(upgrade7vehicle3, VehicleSeat.Passenger);



                            upgrade7ped7.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.Driver);
                            upgrade7ped8.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.Passenger);
                            upgrade7ped9.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.LeftRear);
                            upgrade7ped10.Task.WarpIntoVehicle(upgrade7vehicle4, VehicleSeat.LeftFront);

                            upgrade7ped1.Task.DriveTo(upgrade7vehicle1, upgrade7_markerhumane, 2f, 60f);

                            Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade7ped4, upgrade7vehicle2, upgrade7vehicle1, -1, 100f, 1074528293, 20f, -1, 1f);
                            Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade7ped5, upgrade7vehicle3, upgrade7vehicle1, -1, 100f, 1074528293, 30f, -1, 1f);

                            Function.Call(Hash.SET_DRIVER_ABILITY, upgrade7ped4, 100f);
                            Function.Call(Hash.SET_DRIVER_ABILITY, upgrade7ped5, 100f);

                            Function.Call(Hash.TASK_VEHICLE_HELI_PROTECT, upgrade7ped7, upgrade7vehicle4, upgrade7vehicle1, 90f, 0, 20f, 40, 0);
                           
                            upgrade7_part = 2;
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Catch up on that Humane Labs truck!");
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~g~Boxville.", 1);
                    }

                    if (upgrade7_part == 2) //Get player to kill scene 1
                    {
                        if (Game.Player.Character.IsInVehicle(upgrade7vehicle1))
                        {
                            GTA.UI.Screen.ShowSubtitle("Bring the ~g~Boxville~w~ back to the ~r~lab.", 1);
                            World.DrawMarker(MarkerType.VerticalCylinder, upgrade7_markerlab, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);
                            if (bl == null)
                            {
                                bl = World.CreateBlip(upgrade7_markerlab);
                                bl.Sprite = BlipSprite.RaceFinish;
                                bl.Color = BlipColor.Red;
                                bl.ShowRoute = true;
                            }
                        }
                        else
                        {
                            if (Game.Player.Character.Position.DistanceTo(upgrade7vehicle1.Position) < 12f && upgrade7hostile == false)
                            {
                                turnHostileUpgrade();
                                upgrade7hostile = true;
                            }
                            GTA.UI.Screen.ShowSubtitle("Hijack the ~g~Boxville.", 1);
                            if (bl != null && bl.Exists())
                            {
                                bl.Delete();
                                bl = null;
                            }
                        }
                    }
                }

                if (UpgradeMission == 8)
                {
                    if (GTA.Game.Player.IsAlive != true || upgrade8vehicle1.IsDriveable != true)
                    {
                        if (upgrade8vehicle1.AttachedBlip.Exists())
                        {
                            upgrade8vehicle1.AttachedBlip.Delete();
                        }
                        if (GTA.Game.Player.IsAlive != true)
                        {
                            scaleform_bottom = "You died during the mission.";
                        }
                        if (upgrade8vehicle1.IsDriveable != true)
                        {
                            scaleform_bottom = "The ~g~Frogger~w~ was destroyed.";
                        }
                        if (scaleform_bottom == "The ~g~Frogger~w~ was destroyed." && upgrade8_part == 8)
                        {

                        }
                        else
                        {
                            failUpgradeMission(UpgradeMission);
                        }
                    }

                    if (upgrade8crate1 != null && upgrade8crate1.HeightAboveGround < 0.2f && upgrade8crate1.Model.Hash == -1319782883)
                    {
                        scaleform_bottom = "You destroyed one of the crates.";
                        runParticleOnEntityPos("des_methtrailer", "ent_ray_meth_explosion", upgrade8crate1.Position, 0.75f);
                        runParticleOnEntityPos("core", "exp_grd_sticky_sp", upgrade8crate1.Position, 1f);
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade8_part == 1) //Get player in to Frogger
                    {
                        if (Game.Player.Character.IsInVehicle(upgrade8vehicle1))
                        {
                            upgrade8dropwait = Game.GameTime + 6000;
                            upgrade8_part = 2;
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Get in the air and fly over to the first location. It's as simple as dropping the crates out");
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "once you're over the drop zone. Careful not to loose any of the crates!");
                            upgrade8BlipNext(upgrade8_dropzone1);
                            runParticleOnEntityPos("des_methtrailer", "ent_ray_meth_explosion", new Vector3(0f, 0f, 0f), 0.75f);
                            runParticleOnEntityPos("core", "exp_grd_sticky_sp", new Vector3(0f, 0f, 0f), 1f);
                            runParticleOnEntityPos("scr_exile1", "scr_ex1_dust_impact", new Vector3(0f, 0f, 0f), 0.08f);
                        }
                        GTA.UI.Screen.ShowSubtitle("Get in the ~b~Frogger.", 1);
                    }
                    if (upgrade8_part == 2)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone1) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 3;
                            upgrade8CrateReplace();
                            upgrade8BlipNext(upgrade8_dropzone2);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "See? Not so hard, is it?");
                        }
                        if (Game.GameTime < upgrade8dropwait)
                        {
                            DisplayHelpTextThisFrame("Hit " + ReturnButtonString(activate_key) + " to drop a crate from the ~b~Frogger.");
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone1, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the first ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 3)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone2) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 4;
                            upgrade8CrateReplace();
                            upgrade8BlipNext(upgrade8_dropzone3);
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone2, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the second ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 4)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone3) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 5;
                            upgrade8CrateReplace();
                            upgrade8BlipNext(upgrade8_dropzone4);
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone3, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the third ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 5)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone4) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 6;
                            upgrade8CrateReplace();
                            upgrade8BlipNext(upgrade8_dropzone5);
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone4, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the fourth ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 6)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone5) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 7;
                            upgrade8CrateReplace();
                            upgrade8BlipNext(upgrade8_dropzone6);
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Nearly done - speed it up a bit though we need these chemicals!");
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone5, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the fifth ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 7)
                    {
                        if (upgrade8crate1 != null && upgrade8crate1.Position.DistanceTo(upgrade8_dropzone6) < 15 && upgrade8crate1.HeightAboveGround < 0.4f)
                        {
                            upgrade8_part = 8;
                            upgrade8CrateReplace();
                            if (bl.Exists())
                            {
                                bl.Delete();
                            }
                            if (upgrade8flare1 != null && upgrade8flare1.Exists())
                            {
                                upgrade8flare1.Delete();
                            }
                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Finally! Burn the chopper, you really don't wanna get linked back to those crates..");
                        }
                        World.DrawMarker(MarkerType.VerticalCylinder, upgrade8_dropzone6, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(10.0f, 10.0f, 1.5f), System.Drawing.Color.Yellow);
                        GTA.UI.Screen.ShowSubtitle("Fly to the final ~y~drop zone.", 1);
                    }
                    if (upgrade8_part == 8)
                    {
                        if (upgrade8vehicle1.IsDead)
                        {
                            finishUpgradeMission(8);
                        }
                        if (upgrade8vehicle1.AttachedBlip.Exists() && upgrade8vehicle1.AttachedBlip.Color == BlipColor.Blue)
                        {
                            upgrade8vehicle1.AttachedBlip.Color = BlipColor.Red;
                        }
                        GTA.UI.Screen.ShowSubtitle("Destroy the ~r~Frogger.", 1);
                    }
                }

                if (UpgradeMission == 9)
                {
                    if (GTA.Game.Player.IsAlive != true || (upgrade9vehicle1 != null && upgrade9vehicle1.Exists() && upgrade9vehicle1.IsDriveable == false))
                    {
                        if (upgrade9vehicle1.AttachedBlip.Exists())
                        {
                            upgrade9vehicle1.AttachedBlip.Delete();
                        }
                        if (GTA.Game.Player.IsAlive != true)
                        {
                            scaleform_bottom = "You died during the mission.";
                        }
                        if (upgrade9vehicle1.IsDriveable != true)
                        {
                            scaleform_bottom = "The ~g~Mule~w~ was destroyed.";
                        }
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade9_part == 1) //Get player to catch up with Boxville
                    {
                        if (Game.Player.Character.Position.DistanceTo(upgrade9_marker1) < 25f)
                        {
                            Meth.upgrade9vehicle1 = GTA.World.CreateVehicle(new Model(-2052737935), new GTA.Math.Vector3(1925.598f, 2996.304f, 45.88427f), -172.3694f); //Truck
                            Meth.upgrade9vehicle2 = GTA.World.CreateVehicle(new Model(666166960), new GTA.Math.Vector3(1921.15f, 3013.439f, 45.65034f), 178.5073f); //Baller 1
                            Meth.upgrade9vehicle3 = GTA.World.CreateVehicle(new Model(666166960), new GTA.Math.Vector3(1928.403f, 3021.375f, 45.58162f), 172.4146f); //Baller 2

                            //Convoy peds
                            Meth.upgrade9ped1 = GTA.World.CreatePed(new Model(-245247470), new GTA.Math.Vector3(1919.082f, 3012.946f, 45.69437f), 44.29706f);
                            Meth.upgrade9ped2 = GTA.World.CreatePed(new Model(691061163), new GTA.Math.Vector3(1918.451f, 3014f, 45.66372f), -155.9632f);
                            Meth.upgrade9ped3 = GTA.World.CreatePed(new Model(691061163), new GTA.Math.Vector3(1930.738f, 3022.008f, 45.89248f), -162.0043f);
                            Meth.upgrade9ped5 = GTA.World.CreatePed(new Model(-245247470), new GTA.Math.Vector3(1930.876f, 3020.877f, 45.8495f), -9.943027f);
                            Meth.upgrade9ped4 = GTA.World.CreatePed(new Model(988062523), new GTA.Math.Vector3(1928.8f, 2994.656f, 45.63882f), -158.9522f);
                            Meth.upgrade9ped6 = GTA.World.CreatePed(new Model(-1395868234), new GTA.Math.Vector3(1929.126f, 2993.697f, 45.62851f), -5.999521f);
                            //Heli peds

                            turnUpgradeTeam();

                            Meth.upgrade9ped1.Weapons.Give(WeaponHash.AssaultSMG, 300, true, false);
                            Meth.upgrade9ped2.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                            Meth.upgrade9ped4.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                            Meth.upgrade9ped3.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                            Meth.upgrade9ped5.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                            Meth.upgrade9ped6.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);

                            upgrade9ped1.Task.WarpIntoVehicle(upgrade9vehicle1, VehicleSeat.Driver);
                            upgrade9ped2.Task.WarpIntoVehicle(upgrade9vehicle1, VehicleSeat.Passenger);
                            upgrade9ped3.Task.WarpIntoVehicle(upgrade9vehicle2, VehicleSeat.Driver);
                            upgrade9ped4.Task.WarpIntoVehicle(upgrade9vehicle2, VehicleSeat.Passenger);
                            upgrade9ped5.Task.WarpIntoVehicle(upgrade9vehicle3, VehicleSeat.Driver);
                            upgrade9ped6.Task.WarpIntoVehicle(upgrade9vehicle3, VehicleSeat.Passenger);

                            upgrade9ped1.Task.CruiseWithVehicle(upgrade9vehicle1, 10f);
                            Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade9ped3, upgrade9vehicle2, upgrade9vehicle1, -1, 100f, 1074528293, 20f, -1, 1f);
                            Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade9ped5, upgrade9vehicle3, upgrade9vehicle1, -1, 100f, 1074528293, 30f, -1, 1f);

                            Function.Call(Hash.SET_DRIVER_ABILITY, upgrade9ped3, 100f);
                            Function.Call(Hash.SET_DRIVER_ABILITY, upgrade9ped5, 100f);

                            //Function.Call(Hash.TASK_VEHICLE_HELI_PROTECT, upgrade9ped7, upgrade9vehicle4, upgrade7vehicle1, 80f, 0, 25f, 40f, 0);

                            TextNotification("CHAR_RON", "~b~Ron", "Text message", "Looks like someone got there before us! Check your GPS.");

                            //Setup camera
                            Game.Player.Character.IsPositionFrozen = true;
                            Vector3 vector = new Vector3(2039.8995f, 3181.6011f, 51.2648f);
                            _mainCamera = World.CreateCamera(vector, new Vector3(0f, 0f, 0f), 50f);
                            MainCamera.IsActive = true;
                            World.RenderingCamera = this.MainCamera;
                            if (Game.Player.Character.IsInVehicle())
                            {
                                Game.Player.Character.CurrentVehicle.IsPositionFrozen = true;
                            }
                            GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_NATIVE, Game.Player.Character, "GENERIC_CURSE_MED", "SPEECH_PARAMS_FORCE_SHOUTED");
                            /////////////

                            upgrade9_part = 2;
                        }
                        GTA.UI.Screen.ShowSubtitle("Locate the ~g~Mule.", 1);
                    }

                    if (upgrade9_part == 2) //Run camera sequence
                    {
                        upgrade9cameracounter = upgrade9cameracounter + 0.022f;
                        Vector3 vector2 = new Vector3(upgrade9_marker1.X, upgrade9_marker1.Y, (upgrade9_marker1.Z-8)+upgrade9cameracounter);
                        _mainCamera.PointAt(vector2);
                        if (upgrade9cameracounter>8)
                        {
                            Meth.upgrade9vehicle1.AddBlip();
                            upgrade9vehicle1.AttachedBlip.Sprite = BlipSprite.Truck;
                            upgrade9vehicle1.AttachedBlip.Color = BlipColor.Green;
                            Meth.upgrade9vehicle1.AttachedBlip.ShowRoute = true;
                            upgrade9_part = 3;
                        }
                    }

                    if (upgrade9_part == 3) //Stop camera and start convoy
                    {
                        if (upgrade9cameracounter != 0)
                        {
                            upgrade9cameracounter = 0;
                            this.MainCamera.IsActive = false;
                            World.RenderingCamera = null;
                            Game.Player.Character.IsPositionFrozen = false;
                            if (Game.Player.Character.IsInVehicle())
                            {
                                Game.Player.Character.CurrentVehicle.IsPositionFrozen = false;
                            }
                        }
                        if (Game.Player.Character.IsInVehicle(upgrade9vehicle1))
                        {
                            if (upgrade9vehicle1.AttachedBlip != null)
                            {
                                upgrade9vehicle1.AttachedBlip.Delete();
                            }
                            if (bl == null)
                            {
                                bl = World.CreateBlip(upgrade9_markerlab);
                                bl.Sprite = BlipSprite.RaceFinish;
                                bl.Color = BlipColor.Red;
                                bl.ShowRoute = true;
                            }
                            GTA.UI.Screen.ShowSubtitle("Bring the ~g~Mule~w~ back to the ~r~lab.", 1);
                            World.DrawMarker(MarkerType.VerticalCylinder, upgrade9_markerlab, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(5.0f, 5.0f, 1.5f), System.Drawing.Color.Red);

                            //Random event spawns
                            //Airfield
                            if (Game.Player.Character.Position.DistanceTo(upgrade9_markerjumpdesert) < 300f && (upgrade9vehicle5 == null || upgrade9vehicle5 != null && upgrade9vehicle5.Exists() == false))
                            {
                                Meth.upgrade9vehicle5 = GTA.World.CreateVehicle(new Model(470404958), new GTA.Math.Vector3(1777.544f, 3308.539f, 41.16642f), -72.05384f);
                                Meth.upgrade9ped11 = GTA.World.CreatePed(new Model(-245247470), new GTA.Math.Vector3(1778.385f, 3307.053f, 41.28271f), -159.6325f);
                                Meth.upgrade9ped12 = GTA.World.CreatePed(new Model(691061163), new GTA.Math.Vector3(1777.461f, 3306.595f, 41.2655f), -135.9882f);

                                if (upgrade9ped11.AttachedBlip.Exists() == false)
                                {
                                    upgrade9ped11.AddBlip();
                                    upgrade9ped11.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                    upgrade9ped11.AttachedBlip.Color = BlipColor.Red;
                                }
                                if (upgrade9ped12.AttachedBlip.Exists() == false)
                                {
                                    upgrade9ped12.AddBlip();
                                    upgrade9ped12.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                    upgrade9ped12.AttachedBlip.Color = BlipColor.Red;
                                }

                                int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");
                                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, upgrade9ped11, EnemyRelationShipGroup);
                                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, upgrade9ped12, EnemyRelationShipGroup);

                                Meth.upgrade9ped11.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                                Meth.upgrade9ped12.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);

                                upgrade9ped11.Task.WarpIntoVehicle(upgrade9vehicle5, VehicleSeat.Driver);
                                upgrade9ped12.Task.WarpIntoVehicle(upgrade9vehicle5, VehicleSeat.Passenger);
                                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade9ped11, upgrade9vehicle5, upgrade9vehicle1, -1, 100f, 1074528293, 30f, -1, 1f);
                                Function.Call(Hash.SET_DRIVER_ABILITY, upgrade9ped11, 100f);
                            }
                            //Fire station
                            if (Game.Player.Character.Position.DistanceTo(upgrade9_markerjumpfirestation) < 300f && (upgrade9vehicle6 == null || upgrade9vehicle6 != null && upgrade9vehicle6.Exists() == false))
                            {
                                Meth.upgrade9vehicle6 = GTA.World.CreateVehicle(new Model(666166960), new GTA.Math.Vector3(1717.183f, 3594.836f, 35.1977f), -154.9598f);
                                Meth.upgrade9ped13 = GTA.World.CreatePed(new Model(-1395868234), new GTA.Math.Vector3(1715.082f, 3593.37f, 35.35431f), -151.9995f);
                                Meth.upgrade9ped14 = GTA.World.CreatePed(new Model(653289389), new GTA.Math.Vector3(1715.468f, 3592.61f, 35.33712f), 27.9999f);

                                if (upgrade9ped13.AttachedBlip.Exists() == false)
                                {
                                    upgrade9ped13.AddBlip();
                                    upgrade9ped13.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                    upgrade9ped13.AttachedBlip.Color = BlipColor.Red;
                                }
                                if (upgrade9ped14.AttachedBlip.Exists() == false)
                                {
                                    upgrade9ped14.AddBlip();
                                    upgrade9ped14.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                    upgrade9ped14.AttachedBlip.Color = BlipColor.Red;
                                }

                                int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");
                                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, upgrade9ped13, EnemyRelationShipGroup);
                                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, upgrade9ped14, EnemyRelationShipGroup);

                                Meth.upgrade9ped13.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                                Meth.upgrade9ped14.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);

                                upgrade9ped13.Task.WarpIntoVehicle(upgrade9vehicle6, VehicleSeat.Driver);
                                upgrade9ped14.Task.WarpIntoVehicle(upgrade9vehicle6, VehicleSeat.Passenger);
                                Function.Call(Hash.TASK_VEHICLE_ESCORT, upgrade9ped13, upgrade9vehicle6, upgrade9vehicle1, -1, 100f, 1074528293, 20f, -1, 1f);
                                Function.Call(Hash.SET_DRIVER_ABILITY, upgrade9ped13, 100f);
                            }
                            //Yellow Jack Heli
                            if (Game.Player.Character.Position.DistanceTo(upgrade9_markeryellowjack) < 250f && (upgrade9vehicle4 == null || upgrade9vehicle4 != null && upgrade9vehicle4.Exists() == false))
                            {
                                Meth.upgrade9vehicle4 = GTA.World.CreateVehicle(new Model(837858166), new GTA.Math.Vector3(1983.284f, 3036.982f, 47.44331f), 59.03642f);

                                Meth.upgrade9ped7 = GTA.World.CreatePed(new Model(-1395868234), new GTA.Math.Vector3(1980.491f, 3034.839f, 47.05631f), 45.00013f);
                                Meth.upgrade9ped8 = GTA.World.CreatePed(new Model(988062523), new GTA.Math.Vector3(1979.426f, 3035.513f, 47.05631f), -100.9994f);
                                Meth.upgrade9ped9 = GTA.World.CreatePed(new Model(691061163), new GTA.Math.Vector3(1984.852f, 3039.936f, 47.05617f), 80.05302f);
                                Meth.upgrade9ped10 = GTA.World.CreatePed(new Model(-245247470), new GTA.Math.Vector3(1983.167f, 3040.877f, 47.05618f), -128.9991f);

                                Meth.upgrade9ped7.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                                Meth.upgrade9ped8.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                                Meth.upgrade9ped9.Weapons.Give(WeaponHash.CombatMG, 300, true, false);
                                Meth.upgrade9ped10.Weapons.Give(WeaponHash.CombatMG, 300, true, false);

                                upgrade9ped7.Task.WarpIntoVehicle(upgrade9vehicle4, VehicleSeat.Driver);
                                upgrade9ped8.Task.WarpIntoVehicle(upgrade9vehicle4, VehicleSeat.Passenger);
                                upgrade9ped9.Task.WarpIntoVehicle(upgrade9vehicle4, VehicleSeat.RightRear);
                                upgrade9ped10.Task.WarpIntoVehicle(upgrade9vehicle4, VehicleSeat.LeftRear);

                                int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");
                                foreach (Ped currentped in getUpgradePeds())
                                {
                                    if (currentped != null && currentped.AttachedBlip.Exists() == false && currentped.IsAlive == true)
                                    {
                                        currentped.StaysInVehicleWhenJacked = true;
                                        Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, currentped, 3, false);
                                        Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, currentped, EnemyRelationShipGroup);
                                        if (currentped != upgrade9ped7)
                                        {
                                            currentped.AddBlip();
                                            currentped.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                            currentped.AttachedBlip.Color = BlipColor.Red;
                                        }
                                    }
                                }
                                GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_NATIVE, Game.Player.Character, "GENERIC_CURSE_HIGH", "SPEECH_PARAMS_FORCE_SHOUTED");
                            }
                            if (upgrade9ped7 != null && upgrade9ped7.Exists() && upgrade9ped7.IsAlive && upgrade9ped7.AttachedBlip.Exists() == false && upgrade9ped7.IsInHeli)
                            {
                                Function.Call(Hash.TASK_HELI_CHASE, upgrade9ped7, upgrade9vehicle1, 0f, 0f, 40f);
                                upgrade9ped7.Task.FightAgainstHatedTargets(300f);
                                upgrade9ped7.AddBlip();
                                upgrade9ped7.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                                upgrade9ped7.AttachedBlip.Color = BlipColor.Red;
                            }
                        }
                        else
                        {
                            if (Game.Player.Character.Position.DistanceTo(upgrade9vehicle1.Position) < 12f && upgrade9ped1 != null && upgrade9ped1.Exists() && upgrade9ped1.AttachedBlip.Exists() == false)
                            {
                                turnHostileUpgrade();
                            }
                            if (upgrade9vehicle1.AttachedBlip == null || upgrade9vehicle1.AttachedBlip != null && upgrade9vehicle1.AttachedBlip.Exists() == false)
                            {
                                Meth.upgrade9vehicle1.AddBlip();
                                upgrade9vehicle1.AttachedBlip.Sprite = BlipSprite.Truck;
                                upgrade9vehicle1.AttachedBlip.Color = BlipColor.Green;
                                Meth.upgrade9vehicle1.AttachedBlip.ShowRoute = true;
                            }
                            if (bl != null)
                            {
                                bl.Delete();
                                bl = null;
                            }
                            GTA.UI.Screen.ShowSubtitle("Hijack the ~g~Mule.", 1);
                        }

                        if (upgrade9vehicle4 != null && upgrade9vehicle4.Exists() && upgrade9vehicle4.IsDriveable==false && upgrade9vehicle4.IsInAir == false)
                        {
                            Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, upgrade9ped7, 3, true);
                            Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, upgrade9ped8, 3, true);
                            Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, upgrade9ped9, 3, true);
                            Function.Call(Hash.SET_PED_COMBAT_ATTRIBUTES, upgrade9ped10, 3, true);
                        }

                        if (upgrade9vehicle1.Position.DistanceTo(upgrade9_markerlab) < 10f)
                        {
                            finishUpgradeMission(9);
                        }
                    }
                }

                if (UpgradeMission == 10)
                {
                    if (GTA.Game.Player.IsAlive != true)
                    {
                        failUpgradeMission(UpgradeMission);
                    }

                    if (upgrade10_part == 1)
                    {
                        if (upgrade10ped1.IsDead && upgrade10ped2.IsDead)
                        {
                            Meth.upgrade10ped3 = GTA.World.CreatePed(new Model(-398748745), new GTA.Math.Vector3(1994.827f, 3053.504f, 47.21453f), -21.30706f);
                            Meth.upgrade10ped3.Weapons.Give(WeaponHash.AssaultShotgun, 300, true, false);
                            Meth.upgrade10ped3.AddBlip();
                            upgrade10ped3.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade10ped3.AttachedBlip.Color = BlipColor.Red;
                            upgrade10_part = 2;
                        }
                        if (upgrade10ped1.IsDead && upgrade10ped1.AttachedBlip.Exists())
                        {
                            upgrade10ped1.AttachedBlip.Delete();
                        }
                        if (upgrade10ped2.IsDead && upgrade10ped2.AttachedBlip.Exists())
                        {
                            upgrade10ped2.AttachedBlip.Delete();
                        }
                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~targets.", 1);

                    }
                    if (upgrade10_part == 2)
                    {
                        if (upgrade10ped3.IsDead)
                        {
                            upgrade10ped1.Delete();
                            upgrade10ped2.Delete();
                            upgrade10ped3.AttachedBlip.Delete();
                            Meth.upgrade10vehicle2 = GTA.World.CreateVehicle(new Model(1770332643), new GTA.Math.Vector3(1576.751f, 2903.855f, 56.57074f), 178.4581f);
                            Meth.upgrade10vehicle3 = GTA.World.CreateVehicle(new Model(1762279763), new GTA.Math.Vector3(1581.466f, 2886.678f, 56.83314f), 45.17765f);
                            Meth.upgrade10ped4 = GTA.World.CreatePed(new Model(866411749), new GTA.Math.Vector3(1579.237f, 2901.583f, 56.91332f), -148.9984f);
                            Meth.upgrade10ped5 = GTA.World.CreatePed(new Model(1309468115), new GTA.Math.Vector3(1579.65f, 2900.247f, 56.94117f), 17.99991f);
                            Meth.upgrade10ped6 = GTA.World.CreatePed(new Model(-2077218039), new GTA.Math.Vector3(1580.543f, 2901.413f, 56.91584f), 126.5827f);
                            Meth.upgrade10ped4.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                            Meth.upgrade10ped5.Weapons.Give(WeaponHash.PumpShotgun, 300, true, false);
                            Meth.upgrade10ped6.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);

                            Meth.upgrade10ped4.AddBlip();
                            upgrade10ped4.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade10ped4.AttachedBlip.Color = BlipColor.Red;
                            Meth.upgrade10ped5.AddBlip();
                            upgrade10ped5.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade10ped5.AttachedBlip.Color = BlipColor.Red;
                            Meth.upgrade10ped6.AddBlip();
                            upgrade10ped6.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade10ped6.AttachedBlip.Color = BlipColor.Red;

                            upgrade10_part = 3;
                        }
                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~target.", 1);
                    }
                    if (upgrade10_part == 3)
                    {
                        if (upgrade10ped4.IsDead && upgrade10ped5.IsDead && upgrade10ped6.IsDead)
                        {
                            upgrade10ped3.Delete();
                            Meth.upgrade10vehicle4 = GTA.World.CreateVehicle(new Model(-1372848492), new GTA.Math.Vector3(1092.67f, 2658.324f, 37.57644f), 150.1183f);
                            Meth.upgrade10ped7 = GTA.World.CreatePed(new Model(-2077218039), new GTA.Math.Vector3(1097.013f, 2659.271f, 38.14315f), 153.9186f);
                            Meth.upgrade10ped8 = GTA.World.CreatePed(new Model(42647445), new GTA.Math.Vector3(1095.99f, 2658.381f, 38.14215f), -29.31764f); //Hooker prop
                            Meth.upgrade10ped9 = GTA.World.CreatePed(new Model(348382215), new GTA.Math.Vector3(1096.974f, 2658.089f, 38.14336f), 6.391753f); //Hooker prop
                            Meth.upgrade10ped7.Weapons.Give(WeaponHash.CompactRifle, 300, true, false);

                            Meth.upgrade10ped7.AddBlip();
                            upgrade10ped7.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                            upgrade10ped7.AttachedBlip.Color = BlipColor.Red;

                            upgrade10_part = 4;
                        }
                        if (upgrade10ped4.IsDead && upgrade10ped4.AttachedBlip.Exists())
                        {
                            upgrade10ped4.AttachedBlip.Delete();
                        }
                        if (upgrade10ped5.IsDead && upgrade10ped5.AttachedBlip.Exists())
                        {
                            upgrade10ped5.AttachedBlip.Delete();
                        }
                        if (upgrade10ped6.IsDead && upgrade10ped6.AttachedBlip.Exists())
                        {
                            upgrade10ped6.AttachedBlip.Delete();
                        }
                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~targets.", 1);
                    }
                    if (upgrade10_part == 4) 
                    {
                        if (upgrade10ped7.IsDead)
                        {
                            upgrade10ped4.Delete();
                            upgrade10ped5.Delete();
                            upgrade10ped6.Delete();
                            upgrade10ped7.AttachedBlip.Delete();
                            finishUpgradeMission(10);
                        }
                        GTA.UI.Screen.ShowSubtitle("Kill the ~r~target.", 1);
                    }
                }
            }

            if (OnDeal == 1)
            {
                if (dealNeverWanted == 1 && Game.Player.WantedLevel != 0)
                {
                    Game.Player.WantedLevel = 0;
                }
                foreach (Ped currentped in getDealPeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        if (currentped.IsDead)
                        {
                            failDeal(1);
                        }
                        if (currentped.IsRunning)
                        {
                            failDeal(2);
                        }
                    }
                }

                if (readyToRob == 1)
                {
                    if (Game.Player.Character.Position.DistanceTo(Meth.deal1location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal2location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal3location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal4location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal5location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal6location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal7location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal8location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal9location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal10location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal11location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal12location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal13location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal14location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal15location) < 12f)
                    {
                        Random rnd = new Random();
                        int chooser = rnd.Next(1, 6);
                        string msg2do = "";
                        if (chooser == 1)
                        {
                            msg2do = "It's a set up! Get out of there!";
                        }
                        else if (chooser == 2)
                        {
                            msg2do = "Get out of there man! They're out to rob you.";
                        }
                        else if (chooser == 3)
                        {
                            msg2do = "Those meth heads are trying to stick you. Get out of there!";
                        }
                        else if (chooser == 4)
                        {
                            msg2do = "They're trying to rob you - turn back!";
                        }
                        else if (chooser == 5)
                        {
                            msg2do = "I knew those guys were up to something..!";
                        }

                        TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                        startRobbery(Customer);
                        QuitDeal();

                        readyToRob = 0;
                        WasBeingRobbed = 1;
                    }
                }

                if (readyToPoliceSetup == 1)
                {
                    if (Game.Player.Character.Position.DistanceTo(Meth.deal1location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal2location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal3location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal4location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal5location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal6location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal7location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal8location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal9location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal10location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal11location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal12location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal13location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal14location) < 12f || Game.Player.Character.Position.DistanceTo(Meth.deal15location) < 12f)
                    {
                        Random rnd = new Random();
                        int chooser = rnd.Next(1, 6);
                        string msg2do = "";
                        if (chooser == 1)
                        {
                            msg2do = "It's a set up! Get out of there!";
                        }
                        else if (chooser == 2)
                        {
                            msg2do = "Get out of there man! Those guys are working with the pigs.";
                        }
                        else if (chooser == 3)
                        {
                            msg2do = "Get out of there asap - feds on route! It's a sting!";
                        }
                        else if (chooser == 4)
                        {
                            msg2do = "It's a sting! The pigs are on to us.";
                        }
                        else if (chooser == 5)
                        {
                            msg2do = "I knew those guys were dodgy! Get out of there!";
                        }

                        TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                        GTA.UI.Notification.Show("~r~If the cops kill you, they will confiscate any product you have on your person.");

                        startPoliceSetup();
                        QuitDeal();

                        readyToPoliceSetup = 0;
                        WasBeingPoliceSetup = 1;
                    }
                }
            }

            if (Game.Player.Character.IsAlive == false)
            {
                TriggerPedCheck = 1;
                hashTimerCounter = 0;

                if (Game.Player.Character.GetKiller() != null)
                {
                    killerHash = Game.Player.Character.GetKiller().Model.GetHashCode();
                }
            }

            if (Game.Player.Character.IsAlive == true && WasBeingRobbed == 1 && TriggerPedCheck == 1)
            {
                List<Ped> dealPeds = getDealPeds();
                if (dealPeds.Contains(Game.Player.Character.GetKiller()))
                {
                    Meth.currentGrams = currentGrams - currentDealGrams;
                    Meth.saveStats();

                    scaleform_top = "~r~MISSION FAILED";
                    scaleform_bottom = "Your ~r~meth~w~ supply was robbed.";
                    scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                    scaleform_sound = "negative"; //positive or negative
                    Passed_SelectedIndex = 0;

                    QuitDeal();
                    TriggerPedCheck = 0;
                    WasBeingRobbed = 0;

                    Script.Wait(7000);

                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 6);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "Did you get robbed?! I guess we will just have to take this as a loss..";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "How did you let them rob you?! There goes the meth..";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "You let those meth heads rob you!?";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Next time be more careful. Now they've robbed your meth!";
                    }
                    else if (chooser == 5)
                    {
                        msg2do = "Be more careful, you can't keep getting robbed!";
                    }

                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                    foreach (Ped currentped in dealPeds)
                    {
                        if (currentped != null)
                        {
                            currentped.Delete();
                        }
                    }
                }
            }

            if (Game.Player.Character.IsAlive == true && WasBeingPoliceSetup == 1 && TriggerPedCheck == 1)
            {
                if (killerHash == 368603149 || killerHash == 1581098148 || killerHash == -1699520669 || killerHash == 1939545845 || killerHash == -1920001264)
                {
                    Meth.currentGrams = currentGrams - currentDealGrams;
                    Meth.saveStats();

                    QuitDeal();
                    TriggerPedCheck = 0;
                    WasBeingPoliceSetup = 0;

                    Script.Wait(7000);

                    scaleform_top = "~b~BUSTED!";
                    scaleform_bottom = "Your ~r~meth~w~ supply was seized by the police.";
                    scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                    scaleform_sound = "negative"; //positive or negative
                    Passed_SelectedIndex = 0;

                    Random rnd = new Random();
                    int chooser = rnd.Next(1, 6);
                    string msg2do = "";
                    if (chooser == 1)
                    {
                        msg2do = "I managed to bribe the deputy. Be more careful next time!";
                    }
                    else if (chooser == 2)
                    {
                        msg2do = "I talked with my contacts in the LSPD and they wiped your record.";
                    }
                    else if (chooser == 3)
                    {
                        msg2do = "Don't let this happen again! Bribery is expensive!";
                    }
                    else if (chooser == 4)
                    {
                        msg2do = "Next time be more careful. Don't let them catch you alive!";
                    }
                    else if (chooser == 5)
                    {
                        msg2do = "I phoned Lester and he's wiped your LSPD record. Don't let it happen again.";
                    }

                    TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                    foreach (Ped currentped in getDealPeds())
                    {
                        if (currentped != null)
                        {
                            currentped.Delete();
                        }
                    }
                    foreach (Ped currentped in getSetupPeds())
                    {
                        if (currentped != null)
                        {
                            currentped.Delete();
                        }
                    }
                }
            }

            foreach (Ped currentped in getUpgradePeds())
            {
                if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 100f && OnUpgrade == 0)
                {
                    if (currentped.AttachedBlip.Exists())
                    {
                        currentped.AttachedBlip.Delete();
                    }
                    currentped.Delete();
                }
                if (currentped != null && currentped.IsAlive == false && currentped.AttachedBlip.Exists())
                {
                    currentped.AttachedBlip.Delete();
                }
            }

            World.DrawMarker(MarkerType.VerticalCylinder, Lab_LiquorAce, new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f), new Vector3(0.75f, 0.75f, 0.75f), System.Drawing.Color.Red);
        }

        Vehicle GetTrailerVehicle(Vehicle towVeh)
        {
            var outTrailerVeh = new OutputArgument();
            GTA.Native.Function.Call(Hash.GET_VEHICLE_TRAILER_VEHICLE, towVeh, outTrailerVeh);

            return outTrailerVeh.GetResult<Vehicle>();
        }

        public void upgrade8CrateReplace()
        {
            Vector3 rot = upgrade8crate1.Rotation;
            Vector3 pos = upgrade8crate1.Position;
            Model model = new Model(1877891248);
            model.Request(10000);
            upgrade8crate1.Delete();
            upgrade8crate1 = GTA.World.CreateProp(model, pos, rot, false, false);
            runParticleOnEntityPos("scr_exile1", "scr_ex1_dust_impact", upgrade8crate1.Position, 0.08f);
            upgrade8crate1.SetNoCollision(upgrade8vehicle1, true);
            upgrade8crate1.IsPositionFrozen = false;
            upgrade8crates.Add(upgrade8crate1);
        }

        public void upgrade8BlipNext(Vector3 location)
        {
            if (bl != null && bl.Exists())
            {
                bl.Delete();
                Function.Call(Hash.ANIMPOSTFX_PLAY, "HeistCelebToast", 0, false);
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "CHECKPOINT_NORMAL", "HUD_MINI_GAME_SOUNDSET");
            }
            bl = World.CreateBlip(location);
            bl.Sprite = BlipSprite.TargetD;
            bl.Color = BlipColor.Yellow;

            if (upgrade8flare1 != null && upgrade8flare1.Exists())
            {
                upgrade8flare1.Delete();
            }

            Vector3 rot = new GTA.Math.Vector3(0f, 0f, 0f);
            Model model = new Model(-1564193152);
            model.Request(10000);
            upgrade8flare1 = GTA.World.CreateProp(model, location, rot, false, false);
            AttachFlare(upgrade8flare1, 255f, 0f, 0f);
        }

        public void AttachFlare(Entity p, float cr, float cg, float cb)
        {
            int d = 0;
            while (!Function.Call<bool>(Hash.HAS_NAMED_PTFX_ASSET_LOADED, "scr_apartment_mp") && d < 2000)
            {
                Function.Call(Hash.REQUEST_NAMED_PTFX_ASSET, "scr_apartment_mp");
                d++;
                Script.Wait(0);
            }
            if (Function.Call<bool>(Hash.HAS_NAMED_PTFX_ASSET_LOADED, "scr_apartment_mp"))
            {
                Function.Call(Hash.USE_PARTICLE_FX_ASSET, "scr_apartment_mp");
                int fx = Function.Call<int>(Hash.START_PARTICLE_FX_LOOPED_ON_ENTITY, "scr_finders_package_flare", p, 0f, 0f, 0.1f, 0f, 0f, 0f, 1f, true, true, true);
                Function.Call(Hash.SET_PARTICLE_FX_LOOPED_ALPHA, fx, 1f);
                Function.Call(Hash.SET_PARTICLE_FX_LOOPED_COLOUR, fx, cr, cg, cb, 1f, true);
            }
        }

        public void failDeal(int reason)
        {
            QuitDeal();
            if (reason == 1)
            {
                scaleform_top = "~r~MISSION FAILED";
                scaleform_bottom = "The ~r~buyer~w~ was killed.";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;
            }
            if (reason == 2)
            {
                scaleform_top = "~r~MISSION FAILED";
                scaleform_bottom = "The ~r~buyer~w~ was spooked.";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;
            }
        }

        public void finishUpgradeMission(int upgradeid)
        {
            if (bl != null && bl.Exists())
            {
                bl.Delete();
            }
            foreach (Prop currentprop in getUpgradeProps())
            {
                if (currentprop != null && currentprop.Exists())
                {
                    currentprop.Delete();
                }
            }
            if (upgradeid != 4)
            {
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null)
                    {
                        currentped.Kill();
                        if (Game.Player.Character.Position.DistanceTo(currentped.Position) > 25f && currentped.IsOnScreen == false)
                        {
                            if (currentped.AttachedBlip.Exists())
                            {
                                currentped.AttachedBlip.Delete();
                            }
                            currentped.Delete();
                        }
                    }
                }
                foreach (Vehicle currentvehicle in getUpgradeVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.AttachedBlip != null)
                    {
                        currentvehicle.AttachedBlip.Delete();
                        if (Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 25f && currentvehicle.IsOnScreen == false)
                        {
                            currentvehicle.Delete();
                        }
                    }
                }

            }
            Meth.OnUpgrade = 0;
            Random rnd = new Random();
            string msg2do = "";
            int chooser;
            if (upgradeid == 1 || upgradeid == 2 || upgradeid == 3 || upgradeid == 5 || upgradeid == 7 || upgradeid == 9)
            {
                scaleform_top = "~y~MISSION PASSED";
                scaleform_bottom = "You delivered the ~g~upgrade.";
                scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "positive"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 9);
                if (chooser == 1)
                {
                    msg2do = "Nice one! Now that lab's upgraded, we can cook even more!";
                }
                else if (chooser == 2)
                {
                    msg2do = "Lab upgrade sorted then? Wonderful. Get back to cooking.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Well done upgrading the lab, now we can expand my - I mean our - empire.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Lab has been upgraded. Look forward to higher yields in future!";
                }
                else if (chooser == 5)
                {
                    msg2do = "See - that wasn't so hard, was it?";
                }
                else if (chooser == 6)
                {
                    msg2do = "All sorted? Now let's get cooking.";
                }
                else if (chooser == 7)
                {
                    msg2do = "Higher yields shall be coming our way soon!!";
                }
                else if (chooser == 8)
                {
                    msg2do = "Brilliant, now get back to cooking!";
                }
            }
            if (upgradeid == 4)
            {
                scaleform_top = "~y~MISSION PASSED";
                scaleform_bottom = "You killed the ~r~target.";
                scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "positive"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "Nice one! Now he's out of our way we can expand our territory!";
                }
                else if (chooser == 2)
                {
                    msg2do = "Glad to hear he's out of the picture. Now we can cook even more.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Now he's been taken out we can expand in to his territory.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Now his gang won't bother us we can cook bigger batches in peace.";
                }
                else if (chooser == 5)
                {
                    msg2do = "See - that wasn't so hard, was it? Get out of there!";
                }
                else if (chooser == 6)
                {
                    msg2do = "Easy as pulling the trigger, right? Now get out of there!";
                }
            }
            if (upgradeid == 6)
            {
                scaleform_top = "~y~MISSION PASSED";
                scaleform_bottom = "You destroyed the ~r~targets.";
                scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "positive"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "Those gangs won't be causing us any problems in future. Onwards and upwards!";
                }
                else if (chooser == 2)
                {
                    msg2do = "Now that is sorted, we can cook and move even bigger batches!";
                }
                else if (chooser == 3)
                {
                    msg2do = "With that kind of show of force, nobody will want to mess with us again!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Now we will be the most feared meth dealers in Blaine County!";
                }
                else if (chooser == 5)
                {
                    msg2do = "See - that wasn't so hard, was it?";
                }
                else if (chooser == 6)
                {
                    msg2do = "Easy as pressing the fire button, right? Now we can expand further!";
                }
            }
            if (upgradeid == 8)
            {
                scaleform_top = "~y~MISSION PASSED";
                scaleform_bottom = "You delivered the ~g~crates.";
                scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "positive"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 6);
                if (chooser == 1)
                {
                    msg2do = "Nice! Now that's dealt with, my friend has sent over the chemicals.";
                }
                else if (chooser == 2)
                {
                    msg2do = "My contact has delivered the chemicals to our lab. Upgrade complete.";
                }
                else if (chooser == 3)
                {
                    msg2do = "My contact sends his thanks. The chemicals have arrived at the lab.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Lab has been upgraded. Look forward to higher yields in future!";
                }
                else if (chooser == 5)
                {
                    msg2do = "See - that wasn't so hard, was it?";
                }
                foreach (Prop currentcrate in upgrade8crates)
                {
                    if (currentcrate != null && currentcrate.Exists())
                    {
                        currentcrate.Delete();
                    }
                }
            }
            if (upgradeid == 10)
            {
                scaleform_top = "~y~MISSION PASSED";
                scaleform_bottom = "You killed the ~r~targets.";
                scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "positive"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 6);
                if (chooser == 1)
                {
                    msg2do = "Nice one - now they're out of our way we can push in to their territory.";
                }
                else if (chooser == 2)
                {
                    msg2do = "We should be able to cook even more now they are out of the picture.";
                }
                else if (chooser == 3)
                {
                    msg2do = "Now they're out of the picture we can cook bigger batches in peace.";
                }
                else if (chooser == 4)
                {
                    msg2do = "Great. Now ditch the weapon and burn your outfit.";
                }
                else if (chooser == 5)
                {
                    msg2do = "Easy as pulling the trigger, right?";
                }
            }
            //Vehicle kills
            if (upgradeid == 1)
            {
                upgrade1vehicle1.IsDriveable = false;
            }
            if (upgradeid == 3)
            {
                upgrade3vehicle1.IsDriveable = false;
            }
            if (upgradeid == 7)
            {
                upgrade7vehicle1.IsDriveable = false;
            }
            if (upgradeid == 9)
            {
                upgrade9vehicle1.IsDriveable = false;
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

            upgradeCount = upgradeCount + 1;
            saveStats();
            upgradeLab();
        }

        public void upgradeLab()
        {
            if (upgradeCount > 0)
            {
                cookGramsMin = cookGramsMin_Original * (upgradeCount * upgradeMult);
                cookGramsMax = cookGramsMax_Original * (upgradeCount * upgradeMult);
                cookLargeGramsMin = cookLargeGramsMin_Original * (upgradeCount * upgradeMult);
                cookLargeGramsMax = cookLargeGramsMax_Original * (upgradeCount * upgradeMult);
            }
            if (upgradeCount == 0)
            {
                cookGramsMin = cookGramsMin_Original;
                cookGramsMax = cookGramsMax_Original;
                cookLargeGramsMin = cookLargeGramsMin_Original;
                cookLargeGramsMax = cookLargeGramsMax_Original;
            }
        }

        public void perk7CookSpawn()
        {
            if (perk7hirecooks)
            {
                Meth.perk7ped1 = GTA.World.CreatePed(new Model(-610530921), new GTA.Math.Vector3(1388.107f, 3607.953f, 38.94191f), 100.9953f);
                Meth.perk7ped2 = GTA.World.CreatePed(new Model(261586155), new GTA.Math.Vector3(1391.6768f, 3606.3030f, 38.94191f), 99.89833f);

                int FriendlyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "PLAYER");

                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, perk7ped1, FriendlyRelationShipGroup);
                Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, perk7ped2, FriendlyRelationShipGroup);

                perk7ped1.Task.PlayAnimation("move_clown@generic_idles@", "fidget_look_around_a", 8f, -1, AnimationFlags.Loop);
                perk7ped2.Task.PlayAnimation("anim@amb@business@meth@meth_monitoring_cooking@cooking@", "look_around_v2_cooker", 8f, -1, AnimationFlags.Loop);
            }
            else
            {
                foreach (Ped currentped in getPerk7Peds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }
        }

        public void perk7CookDelete()
        {
            if (perk7hirecooks)
            {
                foreach (Ped currentped in getPerk7Peds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }
        }

        public void upgradeLabPropSpawn()
        {
            if (upgradeCount > 0) //Assorted barrel 1
            {
                Model model = new Model(-566369276);
                //model.Request(10000);
                Meth.decorProp1 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1400.046f, 3603.41f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 93.99851f), false, false);
                Meth.decorProp2 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1394.607f, 3616.064f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -2.000006f), false, false);
                if (decorProp1 != null && decorProp1.Exists())
                {
                    decorProp1.IsPositionFrozen = true;
                }
                if (decorProp2 != null && decorProp2.Exists())
                {
                    decorProp2.IsPositionFrozen = true;
                }
            }
            if (upgradeCount > 2) //Assorted barrel 2
            {
                Model model = new Model(-921781850);
                Meth.decorProp3 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1398.099f, 3602.224f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 14.99984f), false, false);
                Meth.decorProp4 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1392.1f, 3603.2f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -4.000334f), false, false);
                if (decorProp3 != null && decorProp3.Exists())
                {
                    decorProp3.IsPositionFrozen = true;
                }
                if (decorProp4 != null && decorProp4.Exists())
                {
                    decorProp4.IsPositionFrozen = true;
                }
            }
            if (upgradeCount > 4) //Ron oil barrels
            {
                Model model = new Model(-1344435013);
                Meth.decorProp5 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1394.396f, 3604.65f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -56.9996f), false, false);
                Meth.decorProp6 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1395.124f, 3604.456f, 37.94191f), new GTA.Math.Vector3(1.001786E-05f, -5.008956E-06f, -122.2494f), false, false);
                Meth.decorProp7 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1399.64f, 3602.64f, 37.94191f), new GTA.Math.Vector3(1.001786E-05f, -5.008956E-06f, -122.2494f), false, false);
            }
            if (upgradeCount > 6) //Shelf 1
            {
                Model model = new Model(-1181704684);
                Meth.decorProp8 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1391.54f, 3615.22f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -159.9983f), false, false);
            }
            if (upgradeCount > 8) //Balcony crates 1
            {
                Model model = new Model(-230239317);
                Meth.decorProp9 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1394.527f, 3618.21f, 37.94191f), new GTA.Math.Vector3(1.002725E-05f, -5.008956E-06f, -55.99951f), false, false);
            }
            if (upgradeCount > 10) //Meth trays
            {
                Model model = new Model(-1197050094);
                Meth.decorProp10 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1394.088f, 3611.333f, 38.75f), new GTA.Math.Vector3(1.00179E-05f, -5.008956E-06f, 13.24967f), false, false);
                Meth.decorProp11 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1393.89f, 3610.85f, 38.75f), new GTA.Math.Vector3(1.001777E-05f, -5.008955E-06f, 167.2501f), false, false);
            }
            if (upgradeCount > 12) //Balcony crates 2
            {
                Model model = new Model(505870426);
                Meth.decorProp12 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1385.141f, 3615.878f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 11.99985f), false, false);
            }
            if (upgradeCount > 14) //Shelf 2
            {
                Model model = new Model(-406357375);
                Meth.decorProp13 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1387.24f, 3607.45f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 107.9996f), false, false);
            }
            if (upgradeCount > 16) //Globe oil barrels
            {
                Model model = new Model(-1088738506);
                Meth.decorProp14 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1391.599f, 3602.494f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -18.99948f), false, false);
                Meth.decorProp15 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1390.841f, 3599.505f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -160.9986f), false, false);
                Meth.decorProp16 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1387.832f, 3608.64f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 26.00184f), false, false);
                Meth.decorProp17 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1390.267f, 3619.572f, 37.92603f), new GTA.Math.Vector3(0f, 0f, 116.9991f), false, false);
                Meth.decorProp18 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1383.581f, 3617.243f, 37.92603f), new GTA.Math.Vector3(0f, 0f, -149.9996f), false, false);
            }
            if (upgradeCount > 18) //Fridges
            {
                Model model = new Model(1876827312);
                Meth.decorProp19 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1398.023f, 3610.164f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -63.99974f), false, false);
                Meth.decorProp20 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1398.485f, 3609.238f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -72.99979f), false, false);
                if (decorProp19 != null && decorProp19.Exists())
                {
                    decorProp19.IsPositionFrozen = true;
                }
                if (decorProp20 != null && decorProp20.Exists())
                {
                    decorProp20.IsPositionFrozen = true;
                }
            }
            if (upgradeCount > 20) //Ron oil barrels 2
            {
                Model model = new Model(-1344435013);
                Meth.decorProp21 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1391.345f, 3606.986f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -89.99937f), false, false);
                Meth.decorProp22 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1393.588f, 3612.526f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 125.0007f), false, false);
                Meth.decorProp23 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1396.165f, 3613.214f, 37.94187f), new GTA.Math.Vector3(0f, 0f, 30.00057f), false, false);
                Meth.decorProp24 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1389.857f, 3614.677f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 138f), false, false);
            }
            if (upgradeCount > 22) //Gas cyl 1
            {
                Model model = new Model(2138646444);
                Meth.decorProp25 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1393.156f, 3615.898f, 37.94191f), new GTA.Math.Vector3(0f, 0f, 147.9994f), false, false);
                Meth.decorProp26 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1393.999f, 3610.157f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -115.9995f), false, false);
                Meth.decorProp27 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1390.179f, 3599.371f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -93.99934f), false, false);
                Meth.decorProp28 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1387.631f, 3605.768f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -5.999956f), false, false);
                Meth.decorProp29 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1395.462f, 3606.447f, 37.94191f), new GTA.Math.Vector3(0f, 0f, -20.0007f), false, false);
            }
            if (upgradeCount > 24) //Gas buggy outside
            {
                Model model = new Model(2094829076);
                Model model2 = new Model(936543891);
                Meth.decorProp30 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1396.309f, 3625.25f, 34.012f), new GTA.Math.Vector3(0f, 0f, 130.9981f), false, false);
                Meth.decorProp31 = GTA.World.CreateProp(model2, new GTA.Math.Vector3(1394.305f, 3621.13f, 37.92603f), new GTA.Math.Vector3(0f, 0f, 12.99991f), false, false);
                Meth.decorProp32 = GTA.World.CreateProp(model2, new GTA.Math.Vector3(1393.311f, 3620.756f, 37.92603f), new GTA.Math.Vector3(0f, 0f, 146.9992f), false, false);
                Meth.decorProp33 = GTA.World.CreateProp(model2, new GTA.Math.Vector3(1394.315f, 3620.089f, 37.92603f), new GTA.Math.Vector3(0f, 0f, 168.0005f), false, false);
            }
            if (upgradeCount > 26) //Cargo piles
            {
                Model model = new Model(628478833);
                Meth.decorProp34 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1362.687f, 3617.747f, 33.89111f), new GTA.Math.Vector3(0f, 0f, -59.99959f), false, false);
                Meth.decorProp35 = GTA.World.CreateProp(model, new GTA.Math.Vector3(1402.045f, 3628.117f, 33.8927f), new GTA.Math.Vector3(0f, 0f, -78.99975f), false, false);
            }

        }

        public void upgradeLabPropDelete()
        {
            foreach (Prop currentprop in getDecorProps())
            {
                if (currentprop != null && currentprop.Exists())
                {
                    currentprop.Delete();
                }
            }
        }

        public void UpgradeMission6Cleanup()
        {
            try
            {
                foreach (Vehicle currentvehicle in getUpgradeVehicles())
                {
                    if (currentvehicle != null && currentvehicle.Exists() && currentvehicle.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentvehicle.Position) > 200f && currentvehicle.Model.GetHashCode() != 970385471)
                    {
                        currentvehicle.Delete();
                    }
                }
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists() && currentped.IsOnScreen == false && Game.Player.Character.Position.DistanceTo(currentped.Position) > 200f)
                    {
                        currentped.Delete();
                    }
                }
            }
            catch
            {
                GTA.UI.Notification.Show("~r~Meth Dealing - Error cleaning up previous mission scenes");
            }
        }

        public void failUpgradeMission(int upgradeid)
        {
            //Kill enemies
            if (scaleform_bottom == "You died during the mission.")
            {
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        currentped.Delete();
                    }
                }
            }

            Meth.OnUpgrade = 0;
            Random rnd = new Random();
            int chooser = rnd.Next(4300, 12864);
            string msg2do = "";

            if (upgradeid == 4)
            {
                if (upgrade4ped1 != null && upgrade4ped1.AttachedBlip.Exists())
                {
                    upgrade4ped1.AttachedBlip.Delete();
                }
                scaleform_top = "~r~MISSION FAILED";
                scaleform_bottom = "The ~r~target~w~ escaped.";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "No! Now he's got away we may never have another chance..";
                }
                else if (chooser == 2)
                {
                    msg2do = "How did you let him get away? One shot is all it would have taken!";
                }
                else if (chooser == 3)
                {
                    msg2do = "You let him get away - alive! How hard was it to just shoot him?";
                }
                else if (chooser == 4)
                {
                    msg2do = "How'd you manage that!? Next time I'll ask someone else.";
                }
                else if (chooser == 5)
                {
                    msg2do = "You don't even know how hard this was to set up. And you blew it!";
                }
                else if (chooser == 6)
                {
                    msg2do = "Get your head in the game! We needed that and you screwed it.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            else if (upgradeid == 6)
            {
                if (upgrade4ped1 != null && upgrade4ped1.AttachedBlip.Exists())
                {
                    upgrade4ped1.AttachedBlip.Delete();
                }
                scaleform_top = "~r~MISSION FAILED";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "Do you know how much it cost to lease that jet fighter?!";
                }
                else if (chooser == 2)
                {
                    msg2do = "We may never have such a chance like that again. Great..";
                }
                else if (chooser == 3)
                {
                    msg2do = "How hard was it for you to follow my instructions?!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Next time I'll ask someone more responsible!";
                }
                else if (chooser == 5)
                {
                    msg2do = "You had a fighter jet yet you couldn't blow up a few hillbillys?";
                }
                else if (chooser == 6)
                {
                    msg2do = "What am I supposed to tell my higher ups? This can't happen again.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            else if (upgradeid == 7)
            {
                if (upgrade7vehicle1 != null && upgrade7vehicle1.AttachedBlip.Exists())
                {
                    upgrade7vehicle1.AttachedBlip.Delete();
                }
                scaleform_top = "~r~MISSION FAILED";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "We needed that! Next time I'll ask somebody else.";
                }
                else if (chooser == 2)
                {
                    msg2do = "We may never have such a chance like that again. Great..";
                }
                else if (chooser == 3)
                {
                    msg2do = "How hard was it for you to follow my instructions?!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Next time I'll ask someone more responsible!";
                }
                else if (chooser == 5)
                {
                    msg2do = "Just got word - how could you let this happen!?";
                }
                else if (chooser == 6)
                {
                    msg2do = "What am I supposed to tell my higher ups? This can't happen again.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            else if (upgradeid == 8)
            {
                if (upgrade8vehicle1 != null && upgrade8vehicle1.AttachedBlip.Exists())
                {
                    upgrade8vehicle1.AttachedBlip.Delete();
                }
                foreach (Prop currentcrate in upgrade8crates)
                {
                    if (currentcrate != null && currentcrate.Exists())
                    {
                        currentcrate.Delete();
                    }
                }
                scaleform_top = "~r~MISSION FAILED";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 6);
                if (chooser == 1)
                {
                    msg2do = "What am I going to tell my contact?! That was his cargo!";
                }
                else if (chooser == 2)
                {
                    msg2do = "What are you doing? Get your head in the game!";
                }
                else if (chooser == 3)
                {
                    msg2do = "How hard was it for you to follow my instructions?!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Next time I'll ask someone more responsible!";
                }
                else if (chooser == 5)
                {
                    msg2do = "Just got word - how could you let this happen!?";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            else if (upgradeid == 9)
            {
                scaleform_top = "~r~MISSION FAILED";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 7);
                if (chooser == 1)
                {
                    msg2do = "We needed that! Next time I'll ask somebody else.";
                }
                else if (chooser == 2)
                {
                    msg2do = "We may never have such a chance like that again. Great..";
                }
                else if (chooser == 3)
                {
                    msg2do = "How hard was it for you to follow my instructions?!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Next time I'll ask someone more responsible!";
                }
                else if (chooser == 5)
                {
                    msg2do = "Just got word - how could you let this happen!?";
                }
                else if (chooser == 6)
                {
                    msg2do = "What am I supposed to tell my higher ups? This can't happen again.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

                if (upgrade9vehicle1 != null)
                {
                    try
                    {
                        upgrade9vehicle1.AttachedBlip.Delete();
                    }
                    catch
                    { }
                }
            }
            else if (upgradeid == 10)
            {
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        if (currentped.AttachedBlip != null && currentped.AttachedBlip.Exists())
                        {
                            currentped.AttachedBlip.Delete();
                        }
                    }
                }
                scaleform_top = "~r~MISSION FAILED";
                scaleform_bottom = "You died during the mission.";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 6);
                if (chooser == 1)
                {
                    msg2do = "How hard is it to shoot a couple gang bosses?!";
                }
                else if (chooser == 2)
                {
                    msg2do = "We may never have such a chance like that again. Great..";
                }
                else if (chooser == 3)
                {
                    msg2do = "How hard was it for you to follow my instructions?!";
                }
                else if (chooser == 4)
                {
                    msg2do = "Next time I'll ask someone more responsible!";
                }
                else if (chooser == 5)
                {
                    msg2do = "What am I supposed to tell my higher ups? This can't happen again.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }
            else
            {
                Script.Wait(chooser);
                scaleform_top = "~r~MISSION FAILED";
                scaleform_bottom = "You destroyed the ~g~upgrade.";
                scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                scaleform_sound = "negative"; //positive or negative
                Passed_SelectedIndex = 0;

                chooser = rnd.Next(1, 8);
                if (chooser == 1)
                {
                    msg2do = "Messed that one up didn't you.. The upgrade supplies were destroyed.";
                }
                else if (chooser == 2)
                {
                    msg2do = "Nice one.. All that effort to set you up with a job and you blew it!";
                }
                else if (chooser == 3)
                {
                    msg2do = "Just got word - how could you let this happen!?";
                }
                else if (chooser == 4)
                {
                    msg2do = "How'd you manage that!? Next time I'll ask someone else.";
                }
                else if (chooser == 5)
                {
                    msg2do = "Catastrophic failure. Why am I not suprised?";
                }
                else if (chooser == 6)
                {
                    msg2do = "Get your head in the game! We needed that and you screwed it.";
                }
                TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            }

            if (upgradeid != 4)
            {
                foreach (Vehicle currentvehicle in getUpgradeVehicles())
                {
                    if (currentvehicle != null && currentvehicle.AttachedBlip != null)
                    {
                        currentvehicle.AttachedBlip.Delete();
                    }
                }
                foreach (Ped currentped in getUpgradePeds())
                {
                    if (currentped != null && currentped.Exists())
                    {
                        if (currentped.AttachedBlip.Exists())
                        {
                            currentped.AttachedBlip.Delete();
                        }
                        currentped.Kill();
                    }
                }
            }

            foreach (Prop currentprop in getUpgradeProps())
            {
                if (currentprop != null && currentprop.Exists())
                {
                    currentprop.Delete();
                }
            }
            if (bl != null && bl.Exists())
            {
                bl.Delete();
            }

        }

        public void finishBulkSupply(int customer)
        {
            foreach (Prop currentprop in getSupplyProps())
            {
                if (currentprop != null && currentprop.Exists())
                {
                    currentprop.Delete();
                }
            }

            currentSupplies = currentSupplies + currentSupplyDeal;
            saveStats();
            Meth.OnSupply = 0;

            scaleform_top = "~y~MISSION PASSED";
            scaleform_bottom = "You delivered ~b~" + currentSupplyDeal.ToString() + "x supplies.";
            scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
            scaleform_sound = "positive"; //positive or negative
            Passed_SelectedIndex = 0;

            Random rnd = new Random();
            int chooser = rnd.Next(1, 4);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Great. Now you've restocked on supplies we can get back to work.";
            }
            else if (chooser == 2)
            {
                msg2do = "Brilliant. Restocked and back in business. Head back to the lab and get cooking.";
            }
            else if (chooser == 3)
            {
                msg2do = "Nice job picking up the new supplies. Now we can start cooking another batch!";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

            if (bl != null && bl.Exists())
            {
                bl.Delete();
            }
        }

        public void failBulkSupply(int customer)
        {
            Meth.OnSupply = 0;

            scaleform_top = "~r~MISSION FAILED";
            scaleform_bottom = "You destroyed ~b~" + currentSupplyDeal.ToString() + "x supplies.";
            scaleform_colour = 8; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
            scaleform_sound = "negative"; //positive or negative
            Passed_SelectedIndex = 0;

            Random rnd = new Random();
            int chooser = rnd.Next(4300, 12864);
            Script.Wait(chooser);
            chooser = rnd.Next(1, 5);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Messed that one up didn't you..";
            }
            else if (chooser == 2)
            {
                msg2do = "How did you manage that?! All the supplies have been destroyed.";
            }
            else if (chooser == 3)
            {
                msg2do = "The supplies were destroyed with that van..";
            }
            else if (chooser == 4)
            {
                msg2do = "You had one job! $" + (currentSupplyDeal * supplyPrice) + " down the drain..";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);

            if (customer == 101)
            {
                Meth.supply101crate1.Delete();
                Meth.supply101crate2.Delete();
                Meth.supply101crate3.Delete();
            }

            if (bl != null && bl.Exists())
            {
                bl.Delete();
            }
        }

        public void pickupSupplies()
        {
            currentSupplies = currentSupplies + currentSupplyDeal;
            saveStats();
            Game.Player.Character.Task.PlayAnimation("pickup_object", "pickup_low", 8f, -1, AnimationFlags.None);
            Meth.OnSupply = 0;

            scaleform_top = "~y~MISSION PASSED";
            scaleform_bottom = "You picked up ~b~" + currentSupplyDeal.ToString() + "x supplies.";
            scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
            scaleform_sound = "positive"; //positive or negative
            Passed_SelectedIndex = 0;

            Random rnd = new Random();
            int chooser = rnd.Next(4300, 12864);
            Script.Wait(chooser);

            chooser = rnd.Next(1, 4);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Great. Now you've restocked on supplies we can get back to work.";
            }
            else if (chooser == 2)
            {
                msg2do = "Brilliant. Restocked and back in business. Head back to the lab and get cooking.";
            }
            else if (chooser == 3)
            {
                msg2do = "Nice job picking up the new supplies. Now we can start cooking another batch!";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
        }

        public static void AttachEntityToEntity(Entity e1, Entity e2, int boneSelectedIndexE2, Vector3 offsetPos, Vector3 rotation, bool useSoftPinning = false, bool collisionBetweenEnts = false, bool entOneIsPed = false, int vertexSelectedIndex = 0, bool fixedRot = false)
        {
            Function.Call(Hash.ATTACH_ENTITY_TO_ENTITY, e1, e2, boneSelectedIndexE2, offsetPos.X, offsetPos.Y, offsetPos.Z, rotation.X, rotation.Y, rotation.Z, -1f, useSoftPinning, collisionBetweenEnts, entOneIsPed, vertexSelectedIndex, fixedRot);
        }

        public Camera _mainCamera;

        public Camera MainCamera
        {
            get
            {
                return this._mainCamera;
            }
        }

     
        public static void runParticleOnEntityPos(string particlelib, string particlename, Vector3 position, float size)
        {
            if (Function.Call<bool>(Hash.HAS_NAMED_PTFX_ASSET_LOADED, particlelib))
            {
                Function.Call(Hash.USE_PARTICLE_FX_ASSET, particlelib);
                Function.Call<int>(Hash.START_PARTICLE_FX_NON_LOOPED_AT_COORD, particlename,
                position.X, position.Y, position.Z, 0, 0, 0, size, 0, 0, 0);
            }

            else
            {
                Function.Call(Hash.REQUEST_NAMED_PTFX_ASSET, particlelib);
            }
        }

        public static void triggerLabRaid()
        {
            labraidCooldown = Game.GameTime + 900000;
            OnLabraid = 1;
            labraidfailed = 0;

            foreach (Ped currentped in getRaidPeds())
            {
                if (currentped != null && currentped.Exists())
                {
                    currentped.Delete();
                }
            }

            int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");

            int pedmodel1 = 0, pedmodel2 = 0, pedmodel3 = 0, pedmodel4 = 0, pedmodel5 = 0, pedmodel6 = 0, pedmodel7 = 0, pedmodel8 = 0;

            Random rnd = new Random();

            int chooser = rnd.Next(1, 7);
            if (chooser == 1)
            {
                pedmodel1 = 866411749;
                pedmodel2 = 1309468115;
                pedmodel3 = -2077218039;
                pedmodel4 = -613248456;
                pedmodel5 = -398748745;
                pedmodel6 = pedmodel2;
                pedmodel7 = pedmodel5;
                pedmodel8 = pedmodel6;
            }
            if (chooser == 2)
            {
                pedmodel1 = -198252413;
                pedmodel2 = 588969535;
                pedmodel3 = 361513884;
                pedmodel4 = -1492432238;
                pedmodel5 = 599294057;
                pedmodel6 = 1309468115;
                pedmodel7 = -398748745;
                pedmodel8 = pedmodel6;
            }
            if (chooser == 3)
            {
                pedmodel1 = -1176698112;
                pedmodel2 = 275618457;
                pedmodel3 = pedmodel2;
                pedmodel4 = 2119136831;
                pedmodel5 = -9308122;
                pedmodel6 = -1463670378;
                pedmodel7 = pedmodel2;
                pedmodel8 = pedmodel2;
            }
            if (chooser == 4)
            {
                pedmodel1 = -236444766;
                pedmodel2 = -39239064;
                pedmodel3 = -984709238;
                pedmodel4 = -412008429;
                pedmodel5 = pedmodel3;
                pedmodel6 = pedmodel3;
                pedmodel7 = pedmodel4;
                pedmodel8 = pedmodel4;
            }
            if (chooser == 5)
            {
                pedmodel1 = -1872961334;
                pedmodel2 = 663522487;
                pedmodel3 = 846439045;
                pedmodel4 = 62440720;
                pedmodel5 = pedmodel2;
                pedmodel6 = pedmodel2;
                pedmodel7 = pedmodel3;
                pedmodel8 = pedmodel4;
            }
            if (chooser == 6)
            {
                pedmodel1 = 1466037421;
                pedmodel2 = 1226102803;
                pedmodel3 = -1109568186;
                pedmodel4 = 653210662;
                pedmodel5 = 832784782;
                pedmodel6 = -1773333796;
                pedmodel7 = 810804565;
                pedmodel8 = pedmodel4;
            }

            labraidped1 = GTA.World.CreatePed(new Model(pedmodel1), new GTA.Math.Vector3(1402.08f, 3627.701f, 34.89277f), 19.21337f);
            labraidped2 = GTA.World.CreatePed(new Model(pedmodel2), new GTA.Math.Vector3(1400.131f, 3626.995f, 34.89279f), 38.00013f);
            labraidped3 = GTA.World.CreatePed(new Model(pedmodel3), new GTA.Math.Vector3(1400.21f, 3628.284f, 34.89402f), -154.998f);
            labraidped4 = GTA.World.CreatePed(new Model(pedmodel4), new GTA.Math.Vector3(1385.788f, 3605.574f, 34.89447f), 133.0008f);
            labraidped5 = GTA.World.CreatePed(new Model(pedmodel5), new GTA.Math.Vector3(1384.74f, 3604.854f, 34.89449f), -71.99965f);

            chooser = rnd.Next(1, 4);
            if (chooser == 1)
            {
                labraidped6 = GTA.World.CreatePed(new Model(pedmodel6), new GTA.Math.Vector3(1408.832f, 3607.901f, 39.00307f), 55.99979f);
                labraidped7 = GTA.World.CreatePed(new Model(pedmodel7), new GTA.Math.Vector3(1398.678f, 3599.166f, 35.00398f), 0f);
                labraidped8 = GTA.World.CreatePed(new Model(pedmodel8), new GTA.Math.Vector3(1400.954f, 3599.963f, 35.03451f), 17.99998f);
            }
            if (chooser == 2)
            {
                labraidped6 = GTA.World.CreatePed(new Model(pedmodel6), new GTA.Math.Vector3(1408.832f, 3607.901f, 39.00307f), 55.99979f);
                labraidped7 = GTA.World.CreatePed(new Model(pedmodel7), new GTA.Math.Vector3(1406.239f, 3601.248f, 34.98925f), 17.99998f);
                labraidped8 = GTA.World.CreatePed(new Model(pedmodel8), new GTA.Math.Vector3(1380.178f, 3620.944f, 34.89181f), 80.99962f);
            }
            if (chooser == 3)
            {
                labraidped6 = GTA.World.CreatePed(new Model(pedmodel6), new GTA.Math.Vector3(1400.954f, 3599.963f, 35.03451f), 17.99998f);
                labraidped7 = GTA.World.CreatePed(new Model(pedmodel7), new GTA.Math.Vector3(1398.678f, 3599.166f, 35.00398f), 0f);
                labraidped8 = GTA.World.CreatePed(new Model(pedmodel8), new GTA.Math.Vector3(1409.052f, 3619.092f, 34.89446f), -66.99969f);
            }

            foreach (Ped currentped in getRaidPeds())
            {
                if (currentped != null && currentped.Exists())
                {
                    currentped.AddBlip();
                    currentped.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                    currentped.AttachedBlip.Color = BlipColor.Red;

                    Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, currentped, EnemyRelationShipGroup);

                    chooser = rnd.Next(1, 14);
                    if (chooser == 1)
                    {
                        currentped.Weapons.Give(WeaponHash.AssaultRifle, 300, true, false);
                    }
                    if (chooser == 2)
                    {
                        currentped.Weapons.Give(WeaponHash.CombatPistol, 300, true, false);
                    }
                    if (chooser == 3)
                    {
                        currentped.Weapons.Give(WeaponHash.MG, 300, true, false);
                    }
                    if (chooser == 4)
                    {
                        currentped.Weapons.Give(WeaponHash.MicroSMG, 300, true, false);
                    }
                    if (chooser == 5)
                    {
                        currentped.Weapons.Give(WeaponHash.MachinePistol, 300, true, false);
                    }
                    if (chooser == 6)
                    {
                        currentped.Weapons.Give(WeaponHash.SMG, 300, true, false);
                    }
                    if (chooser == 7)
                    {
                        currentped.Weapons.Give(WeaponHash.MiniSMG, 300, true, false);
                    }
                    if (chooser == 8)
                    {
                        currentped.Weapons.Give(WeaponHash.DoubleBarrelShotgun, 300, true, false);
                    }
                    if (chooser == 9)
                    {
                        currentped.Weapons.Give(WeaponHash.CompactRifle, 300, true, false);
                    }
                    if (chooser == 10)
                    {
                        currentped.Weapons.Give(WeaponHash.SmokeGrenade, 300, true, false);
                    }
                    if (chooser == 11)
                    {
                        currentped.Weapons.Give(WeaponHash.VintagePistol, 300, true, false);
                    }
                    if (chooser == 12)
                    {
                        currentped.Weapons.Give(WeaponHash.SNSPistol, 300, true, false);
                    }
                    if (chooser == 13)
                    {
                        currentped.Weapons.Give(WeaponHash.APPistol, 300, true, false);
                    }
                }
            }

            chooser = rnd.Next(1, 7);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Watch your back! There's a gang on their way to raid the lab.";
            }
            else if (chooser == 2)
            {
                msg2do = "Raid incoming! Don't let the enemy gang take everything we've worked for.";
            }
            else if (chooser == 3)
            {
                msg2do = "Just got word of a raid on our lab! Kill them all!";
            }
            else if (chooser == 4)
            {
                msg2do = "Don't let them take our stash! Kill anybody that tries to raid.";
            }
            else if (chooser == 5)
            {
                msg2do = "You need to defend the lab! Don't let the raiders take everything we've worked for.";
            }
            else if (chooser == 6)
            {
                msg2do = "Gang members are outside our lab. Defend it with your life!";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
            GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_NATIVE, Game.Player.Character, "GENERIC_CURSE_HIGH", "SPEECH_PARAMS_FORCE_SHOUTED");

        }

        public static void finishLabRaid()
        {
            OnLabraid = 0;

            Script.Wait(2000);

            scaleform_top = "~y~RAID PASSED";
            scaleform_bottom = "You killed the ~r~raiders.";
            scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
            scaleform_sound = "positive"; //positive or negative
            Passed_SelectedIndex = 0;

            Random rnd = new Random();

            Script.Wait(3000);

            int chooser = rnd.Next(1, 6);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Well done - let's hope they don't come back!";
            }
            else if (chooser == 2)
            {
                msg2do = "Guessing you resolved our issue? Now get back to work.";
            }
            else if (chooser == 3)
            {
                msg2do = "Let's hope they learnt their lesson..";
            }
            else if (chooser == 4)
            {
                msg2do = "Let's just hope they didn't damage any of our equipment!";
            }
            else if (chooser == 5)
            {
                msg2do = "Get back to cooking, I'll make sure they don't come back.";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
        }

        public static void failLabRaid()
        {
            labraidfailed = 1;
            OnLabraid = 0;
            currentGrams = 0;
            saveStats();

            foreach (Ped currentped in getRaidPeds())
            {
                if (currentped != null && currentped.Exists())
                {
                    currentped.Delete();
                }
            }

            Random rnd = new Random();
            int chooser = rnd.Next(9000, 15000);
            Script.Wait(chooser);

            chooser = rnd.Next(1, 5);
            string msg2do = "";
            if (chooser == 1)
            {
                msg2do = "Now we're screwed! They took the entire stash.";
            }
            else if (chooser == 2)
            {
                msg2do = "How did you manage that?! Our entire meth stash has been stolen.";
            }
            else if (chooser == 3)
            {
                msg2do = "Gone! It's all gone! Every last gram has been taken by those thugs.";
            }
            else if (chooser == 4)
            {
                msg2do = "They took our entire stockpile of meth. Next time make sure they don't survive.";
            }

            TextNotification("CHAR_RON", "~b~Ron", "Text message", msg2do);
        }

        public static void sellToCustomer()
        {

            Game.Player.Money += currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier));
            Meth.currentGrams = currentGrams - currentDealGrams;
            Meth.saveStats();

            Vector3 rot = new GTA.Math.Vector3(1388.729f, 3613.192f, 42.63286f);
            Model model = new Model(285917444);
            model.Request(10000);
            methbagprop = GTA.World.CreateProp(model, supply1location, rot, false, false);
            methbagprop.SetNoCollision(GTA.Game.Player.Character, true);
            methbagprop.Position = Game.Player.Character.Position;
            AttachEntityToEntity(methbagprop, GTA.Game.Player.Character, GTA.Game.Player.Character.GetBoneIndex(Bone.IKRightHand), new Vector3(0.1430f, 0.0390f, 0f), new Vector3(-45.127f, 8f, 0f), false, false, false, 2, true);

            Game.Player.Character.Task.PlayAnimation("mp_common", "givetake1_b", 8f, -1, AnimationFlags.UpperBodyOnly);

            Meth.OnDeal = 0;

            scaleform_top = "~y~MISSION PASSED";
            scaleform_bottom = "You sold the meth and earnt~g~ $" + (currentDealGrams * Convert.ToInt32(Math.Ceiling(priceGram * perk3bluemethmultiplier))).ToString();
            scaleform_colour = 20; // color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
            scaleform_sound = "positive"; //positive or negative
            Passed_SelectedIndex = 0;

            Script.Wait(1100);
            methbagprop.Delete();
        }

        public void cookmeth()
        {
            if (Game.Player.Character.Position.DistanceTo(Meth.Lab_LiquorAce) > 3.5 && perk1chef == true)
            {
                Meth.TimerCounterAutoBatch = 0;
                Meth.CookingCooldown = 1;
                smallBatchStart = 1;
                currentSupplies = currentSupplies - 10;
                GTA.UI.Notification.Show("~g~Started cooking small batch!~w~ Meth will be ready shortly.");
            }
            else
            {
                Ped character = Game.Player.Character;
                Random rnd = new Random();
                int batchgrams = rnd.Next(cookGramsMin, cookGramsMax + 1);
                currentSupplies = currentSupplies - 1;
                currentGrams = currentGrams + batchgrams;
                saveStats();

                Meth.TimerCounter = 0;
                Meth.CookingCooldown = 1;
                GTA.UI.Screen.ShowSubtitle("Cooking ~r~meth..", 10000);

                Game.Player.Character.IsPositionFrozen = true;
                Game.Player.Character.PositionNoOffset = new Vector3(1389.3273f, 3604.7805f, 38.9419f);
                Game.Player.Character.Rotation = new Vector3(0f, 0f, -68.6012f);
                Vector3 vector2 = new Vector3(1391.9039f, 3603.8345f, 39.8488f);
                Vector3 vector = Game.Player.Character.Position;
                this._mainCamera = World.CreateCamera(vector2, new Vector3(0f, 0f, 0f), 50f);
                _mainCamera.PointAt(vector);
                MainCamera.IsActive = true;
                World.RenderingCamera = this.MainCamera;
                Game.Player.Character.Rotation = new Vector3(0f, 0f, -70.5439f);
                Game.Player.Character.Task.PlayAnimation("anim@amb@business@meth@meth_monitoring_cooking@cooking@", "look_around_v1_cooker", 1f, 11500, false, -1f);
                Script.Wait(6000);
                GTA.UI.Screen.FadeOut(1000);
                Script.Wait(3000);
                if (cookSmallTimeDay == 1)
                {
                    GTA.World.CurrentDayTime = GTA.World.CurrentDayTime.Add(TimeSpan.FromHours(12));
                }
                GTA.UI.Screen.FadeIn(1000);
                Script.Wait(1500);
                Function.Call(Hash.ANIMPOSTFX_PLAY, "HeistCelebToast", 0, false);
                Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "PURCHASE", "HUD_LIQUOR_STORE_SOUNDSET");
                Script.Wait(800);
                character.Task.ClearAllImmediately();
                this.MainCamera.IsActive = false;
                World.RenderingCamera = null;
                Game.Player.Character.IsPositionFrozen = false;
                GTA.UI.Notification.Show("Batch finished! This cook produced ~g~" + batchgrams.ToString() + "g ~w~of ~r~meth.");

                int chooser = rnd.Next(1, 3);
                if (chooser == 1)
                {
                    GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_NATIVE, Game.Player.Character, "GENERIC_THANKS", "Speech_Params_Force_Normal_Clear");
                }
                else
                {
                    GTA.Native.Function.Call(Hash.PLAY_PED_AMBIENT_SPEECH_NATIVE, Game.Player.Character, "CHAT_RESP", "Speech_Params_Force_Normal_Clear");
                }
            }
        }

        public static void cookmethlarge()
        {
            Meth.TimerCounterAutoBatch = 0;
            Meth.CookingCooldown = 1;
            largeBatchStart = 1;
            currentSupplies = currentSupplies - 10;
            GTA.UI.Notification.Show("~g~Started cooking large batch!~w~ Meth will be ready shortly.");
        }

        public static void cookmethverylarge()
        {
            Meth.TimerCounterAutoBatch = 0;
            Meth.CookingCooldown = 1;
            large2BatchStart = 1;
            currentSupplies = currentSupplies - 50;
            GTA.UI.Notification.Show("~g~Started cooking very large batch!~w~ Meth will be ready shortly.");
        }

        public static void autoBatchFinished(string mode)
        {
            Random rnd = new Random();
            if (mode=="small")
            {
                int batchgrams = rnd.Next(cookGramsMin, cookGramsMax + 1);
                currentGrams = currentGrams + batchgrams;
                saveStats();
                GTA.UI.Notification.Show("Small batch finished! This cook produced ~g~" + batchgrams.ToString() + "g ~w~of ~r~meth.");
            }
            if (mode=="vlarge")
            {
                int batchgrams = rnd.Next(cookLargeGramsMin*5, cookLargeGramsMax*5 + 1);
                currentGrams = currentGrams + batchgrams;
                saveStats();
                GTA.UI.Notification.Show("Very large batch finished! This cook produced ~g~" + batchgrams.ToString() + "g ~w~of ~r~meth.");
            }
            else
            {
                int batchgrams = rnd.Next(cookLargeGramsMin, cookLargeGramsMax + 1);
                currentGrams = currentGrams + batchgrams;
                saveStats();
                GTA.UI.Notification.Show("Large batch finished! This cook produced ~g~" + batchgrams.ToString() + "g ~w~of ~r~meth.");
            }
            Function.Call(Hash.ANIMPOSTFX_PLAY, "HeistCelebToast", 0, false);
            Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "PURCHASE", "HUD_LIQUOR_STORE_SOUNDSET");
        }

        public static void startRobbery(int customerid)
        {
            int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");
            foreach (Ped currentped in getDealPeds())
            {
                if (currentped != null)
                {
                    Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, currentped, EnemyRelationShipGroup);
                }
            }
        }

        public static void startPoliceSetup()
        {
            Vector3 spawnbase = Game.Player.Character.Position.Around(70);
            Vector3 spawnbase2 = Game.Player.Character.Position.Around(90);
            Vector3 spawnbase3 = Game.Player.Character.Position.Around(110);

            Vector3 spawn1 = GenerateSpawnPos(spawnbase, Nodetype.AnyRoad, false);
            Vector3 spawn2 = GenerateSpawnPos(spawnbase2, Nodetype.AnyRoad, false);
            Vector3 spawn3 = GenerateSpawnPos(spawnbase3, Nodetype.AnyRoad, false);

            setup1vehicle1 = World.CreateVehicle(new Model(-1973172295), spawn1, 46.92113f);
            setup1vehicle2 = World.CreateVehicle(new Model(-1973172295), spawn2, 46.92113f);
            setup1vehicle3 = World.CreateVehicle(new Model(-1973172295), spawn3, 46.92113f);

            setup1ped1 = World.CreatePed(new Model(1581098148), setup1vehicle1.Position, -100.99f);
            setup1ped2 = World.CreatePed(new Model(1581098148), setup1vehicle2.Position, 136.3854f);
            setup1ped3 = World.CreatePed(new Model(1581098148), setup1vehicle3.Position, 136.3854f);

            setup1ped1.Weapons.Give(WeaponHash.PumpShotgun, 100, true, false);
            setup1ped2.Weapons.Give(WeaponHash.Pistol, 100, true, false);
            setup1ped3.Weapons.Give(WeaponHash.PumpShotgun, 100, true, false);

            setup1ped1.Task.WarpIntoVehicle(setup1vehicle1, VehicleSeat.Driver);
            setup1ped2.Task.WarpIntoVehicle(setup1vehicle2, VehicleSeat.Driver);
            setup1ped3.Task.WarpIntoVehicle(setup1vehicle3, VehicleSeat.Driver);
            setup1ped1.Task.Wait(10000);
            setup1ped2.Task.Wait(10000);
            setup1ped3.Task.Wait(10000);
            setup1ped1.Task.DriveTo(setup1vehicle1, Game.Player.Character.Position, 15, 70);
            setup1ped2.Task.DriveTo(setup1vehicle2, Game.Player.Character.Position, 15, 70);
            setup1ped3.Task.DriveTo(setup1vehicle3, Game.Player.Character.Position, 15, 70);

            setup1vehicle1.SirenActive = true;
            setup1vehicle2.SirenActive = true;
            setup1vehicle3.SirenActive = true;

            Game.Player.WantedLevel = 3;

            foreach (Ped currentped in getDealPeds())
            {
                if (currentped != null && currentped.Exists() && Game.Player.Character.Position.DistanceTo(currentped.Position) < 100f)
                {
                    currentped.Task.ReactAndFlee(Game.Player.Character);
                }
            }
        }

        public static Vector3 GenerateSpawnPos(Vector3 desiredPos, Nodetype roadtype, bool sidewalk)
        {
            Vector3 finalpos = Vector3.Zero;
            bool ForceOffroad = false;

            OutputArgument outArgA = new OutputArgument();
            int NodeNumber = 1;
            int type = 0;

            if (roadtype == Nodetype.AnyRoad) type = 1;
            if (roadtype == Nodetype.Road) type = 0;
            if (roadtype == Nodetype.Offroad) { type = 1; ForceOffroad = true; }
            if (roadtype == Nodetype.Water) type = 3;


            int NodeID = Function.Call<int>(Hash.GET_NTH_CLOSEST_VEHICLE_NODE_ID, desiredPos.X, desiredPos.Y, desiredPos.Z, NodeNumber, type, 300f, 300f);

            if (ForceOffroad)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (!Function.Call<bool>(Hash.GET_VEHICLE_NODE_IS_SWITCHED_OFF, NodeID))
                    {
                        NodeID = Function.Call<int>(Hash.GET_NTH_CLOSEST_VEHICLE_NODE_ID, desiredPos.X, desiredPos.Y, desiredPos.Z, NodeNumber, type, 300f, 300f);
                        NodeNumber++;
                    }
                }
            }

            Function.Call(Hash.GET_VEHICLE_NODE_POSITION, NodeID, outArgA);
            finalpos = outArgA.GetResult<Vector3>();

            if (sidewalk) finalpos = World.GetNextPositionOnSidewalk(finalpos);
            return finalpos;

        }

        public static void turnHostileUpgrade()
        {
            int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "HATES_PLAYER");

            foreach (Ped currentped in getUpgradePeds())
            {
                if (currentped != null && currentped.IsAlive == true)
                {
                    Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, currentped, EnemyRelationShipGroup);
                    currentped.Task.FightAgainstHatedTargets(300f, 1000000);
                    if (currentped.AttachedBlip.Exists() == false && upgradeEnemyBlipToggle==1)
                    {
                        currentped.AddBlip();
                        currentped.AttachedBlip.Sprite = BlipSprite.Crosshair2;
                        currentped.AttachedBlip.Color = BlipColor.Red;
                    }
                }
            }
        }

        public static void turnUpgradeTeam()
        {
            int EnemyRelationShipGroup = Function.Call<int>(Hash.GET_HASH_KEY, "PRIVATE_SECURITY");

            foreach (Ped currentped in getUpgradePeds())
            {
                if (currentped != null && currentped.IsAlive == true)
                {
                    Function.Call(Hash.SET_PED_RELATIONSHIP_GROUP_HASH, currentped, EnemyRelationShipGroup);
                }
            }
        }

        public static void scaleformmsg()
        {
            switch (Passed_SelectedIndex)
            {
                case 0:
                    {
                        Scale = Function.Call<int>((Hash)0x11FE353CF9733E6F, "MIDSIZED_MESSAGE");
                        timen = (int)Game.GameTime + 1500;
                        Passed_SelectedIndex = 1;
                    }
                    break;

                case 1:
                    {
                        if ((int)Game.GameTime > timen)
                        {
                            if (Function.Call<bool>(Hash.HAS_SCALEFORM_MOVIE_LOADED, Scale))
                            {
                                Function.Call(Hash.ANIMPOSTFX_PLAY, "SuccessNeutral", 8500, false);

                                if (scaleform_sound == "positive")
                                {
                                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "SHOOTING_RANGE_ROUND_OVER", "HUD_AWARDS");
                                    Function.Call(Hash.PLAY_MISSION_COMPLETE_AUDIO, "MICHAEL_BIG_01");
                                }
                                else
                                {
                                    Function.Call(Hash.PLAY_SOUND_FRONTEND, -1, "MP_Flash", "WastedSounds");
                                }

                                Function.Call(Hash.BEGIN_SCALEFORM_MOVIE_METHOD, Scale, "SHOW_SHARD_MIDSIZED_MESSAGE");


                                Function.Call(Hash.BEGIN_TEXT_COMMAND_SCALEFORM_STRING, "STRING");
                                Function.Call((Hash)0x6C188BE134E074AA, scaleform_top);
                                Function.Call(Hash.END_TEXT_COMMAND_SCALEFORM_STRING);

                                Function.Call(Hash.BEGIN_TEXT_COMMAND_SCALEFORM_STRING, "STRING");
                                Function.Call((Hash)0x6C188BE134E074AA, scaleform_bottom);
                                Function.Call(Hash.END_TEXT_COMMAND_SCALEFORM_STRING);

                                Function.Call(Hash.END_SCALEFORM_MOVIE_METHOD);

                                timen = (int)Game.GameTime + 10000; // time to display message

                                Passed_SelectedIndex = 2;
                            }
                        }

                    }
                    break;

                case 2:
                    {
                        if (Function.Call<bool>(Hash.HAS_SCALEFORM_MOVIE_LOADED, Scale))
                        {
                            if ((int)Game.GameTime <= timen)
                            {
                                Function.Call(Hash.DRAW_SCALEFORM_MOVIE_FULLSCREEN, Scale, 255, 255, 255, 255);
                            }
                            else if ((int)Game.GameTime < timen + 100)
                            {
                                Function.Call(Hash.BEGIN_SCALEFORM_MOVIE_METHOD, Scale, "SHARD_ANIM_OUT");
                                Function.Call(Hash.SCALEFORM_MOVIE_METHOD_ADD_PARAM_INT, scaleform_colour);// color 0,1=white 2=black 3=grey 6,7,8=red 9,10,11=blue 12,13,14=yellow 15,16,17=orange 18,19,20=green 21,22,23=purple 
                                Function.Call(Hash.SCALEFORM_MOVIE_METHOD_ADD_PARAM_FLOAT, .33f);

                                Function.Call(Hash.END_SCALEFORM_MOVIE_METHOD);
                                timen -= 100;
                            }
                            else if ((int)Game.GameTime < timen + 2000)
                            {
                                Function.Call(Hash.DRAW_SCALEFORM_MOVIE_FULLSCREEN, Scale, 255, 255, 255, 255);
                            }
                            else
                            {
                                Passed_SelectedIndex = 3;
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        unsafe
                        {
                            int b = Scale;

                            Function.Call(Hash.SET_SCALEFORM_MOVIE_AS_NO_LONGER_NEEDED, &b);

                            Passed_SelectedIndex = -1;

                        }
                    }
                    break;
            }
        }

        public static List<Ped> getPerk7Peds()
        {
            List<Ped> perkPeds = new List<Ped>() {perk7ped1,perk7ped2 };
            return perkPeds;
        }

        public static List<Ped> getRaidPeds()
        {
            List<Ped> raidPeds = new List<Ped>() { labraidped1,labraidped2,labraidped3,labraidped4,labraidped5,labraidped6,labraidped7,labraidped8 };
            return raidPeds;
        }

        public static List<Ped> getUpgradePeds()
        {
            List<Ped> upgradePeds = new List<Ped>() { upgrade1ped1, upgrade1ped2, upgrade1ped3, upgrade1ped4, upgrade1ped5, upgrade1ped6, upgrade1ped7, upgrade1ped8, upgrade1ped9, upgrade1ped10, upgrade1ped11, upgrade1ped12, upgrade1ped13, upgrade1ped14, upgrade1ped15, upgrade1ped16, upgrade1ped17, upgrade1ped18, upgrade2ped1, upgrade2ped2, upgrade2ped3, upgrade2ped4, upgrade2ped5, upgrade2ped6, upgrade2ped7, upgrade2ped8, upgrade2ped9, upgrade2ped10, upgrade2ped11, upgrade2ped12, upgrade3ped1, upgrade3ped2, upgrade3ped3, upgrade3ped4, upgrade3ped5, upgrade3ped6, upgrade3ped7, upgrade3ped8, upgrade3ped9, upgrade3ped10, upgrade3ped11, upgrade3ped12, upgrade3ped13, upgrade4ped1, upgrade4ped2, upgrade4ped3, upgrade4ped4, upgrade4ped5, upgrade4ped6, upgrade4ped7, upgrade4ped8, upgrade4ped9, upgrade4ped10, upgrade4ped11, upgrade4ped12, upgrade4ped13, upgrade4ped14, upgrade4ped15, upgrade4ped16, upgrade4ped17, upgrade4ped18, upgrade4ped19, upgrade4ped20, upgrade4ped21, upgrade4ped22, upgrade4ped23, upgrade4ped24, upgrade4ped25, upgrade5ped1,upgrade5ped2,upgrade5ped3,upgrade5ped4,upgrade5ped5,upgrade5ped7,upgrade5ped8,upgrade5ped9, upgrade5ped10, upgrade5ped11, upgrade5ped12, upgrade5ped13, upgrade6ped1,upgrade6ped2,upgrade6ped3,upgrade6ped4,upgrade6ped5,upgrade6ped6,upgrade6ped7, upgrade7ped1,upgrade7ped2,upgrade7ped3,upgrade7ped4,upgrade7ped5,upgrade7ped6, upgrade7ped7,upgrade7ped8,upgrade7ped9,upgrade7ped10, upgrade9ped1,upgrade9ped2,upgrade9ped3,upgrade9ped4,upgrade9ped5,upgrade9ped6,upgrade9ped7,upgrade9ped8,upgrade9ped9,upgrade9ped10, upgrade9ped11,upgrade9ped12,upgrade9ped13,upgrade9ped14, upgrade10ped1,upgrade10ped2,upgrade10ped3,upgrade10ped4,upgrade10ped5,upgrade10ped6,upgrade10ped7,upgrade10ped8,upgrade10ped9};
            return upgradePeds;
        }

        public static List<Vehicle> getUpgradeVehicles()
        {
            List<Vehicle> upgradeVehicles = new List<Vehicle>() { upgrade1vehicle1,upgrade1vehicle2,upgrade1vehicle3,upgrade1vehicle4,upgrade1vehicle5,upgrade1vehicle6,upgrade1vehicle7,upgrade1vehicle8,upgrade1vehicle9,upgrade2vehicle1,upgrade2vehicle2,upgrade2vehicle3,upgrade2vehicle4,upgrade2vehicle5,upgrade2vehicle6,upgrade2vehicle7,upgrade2vehicle8,upgrade2vehicle9,upgrade2vehicle10,upgrade3vehicle1,upgrade3vehicle2,upgrade3vehicle3,upgrade3vehicle4,upgrade3vehicle5,upgrade3vehicle6,upgrade3vehicle7,upgrade3vehicle8, upgrade4vehicle1, upgrade4vehicle2, upgrade4vehicle3, upgrade4vehicle4, upgrade4vehicle5, upgrade4vehicle6, upgrade4vehicle7, upgrade4vehicle8, upgrade4vehicle9, upgrade4vehicle10, upgrade4vehicle11, upgrade4vehicle12, upgrade4vehicle13, upgrade5vehicle1,upgrade5vehicle2,upgrade5vehicle3,upgrade5vehicle4,upgrade6vehicle1,upgrade6vehicle2,upgrade6vehicle3,upgrade6vehicle4,upgrade6vehicle5,upgrade6vehicle6,upgrade6vehicle7,upgrade6vehicle8,upgrade6vehicle9, upgrade7vehicle1, upgrade7vehicle2, upgrade7vehicle3, upgrade7vehicle4, upgrade8vehicle1, upgrade9vehicle1,upgrade9vehicle2,upgrade9vehicle3,upgrade9vehicle4, upgrade9vehicle5,upgrade9vehicle6, upgrade10vehicle1,upgrade10vehicle2, upgrade10vehicle3, upgrade10vehicle4};
            return upgradeVehicles;
        }

        public static List<Prop> getUpgradeProps()
        {
            List<Prop> upgradeProps = new List<Prop>() { upgrade1barrel1,upgrade1barrel2,upgrade1barrel3,upgrade3crate1,upgrade5crate1, upgrade8crate1, upgrade8flare1 };
            return upgradeProps;
        }

        public static List<Ped> getDealPeds()
        {
            List<Ped> dealPeds = new List<Ped>() { deal1ped1, deal1ped2, deal1ped3, deal1ped4, deal2ped1, deal2ped2, deal3ped1, deal3ped2, deal4ped1, deal4ped2, deal4ped3, deal5ped1, deal6ped1, deal6ped2, deal7ped1, deal8ped1, deal8ped2, deal8ped3, deal9ped1, deal9ped2, deal10ped1, deal10ped2, deal11ped1, deal11ped2, deal11ped3, deal11ped4, deal11ped5, deal11ped6, deal11ped7, deal12ped1, deal12ped2, deal12ped3, deal12ped4, deal12ped5, deal12ped6, deal13ped1, deal13ped2, deal14ped1, deal14ped2, deal14ped3, deal14ped4, deal15ped1 };
            return dealPeds;
        }

        public static List<Vehicle> getDealVehicles()
        {
            List<Vehicle> upgradeVehicles = new List<Vehicle>() { deal1vehicle1,deal2vehicle1,deal3vehicle1,deal4vehicle1,deal5vehicle1,deal8vehicle1,deal10vehicle1,deal11vehicle1,deal11vehicle2,deal11vehicle3,deal11vehicle4,deal11vehicle5,deal11vehicle6,deal11vehicle7,deal12vehicle1,deal12vehicle2,deal13vehicle1,deal14vehicle1 };
            return upgradeVehicles;
        }

        public static List<Ped> getSupplyPeds()
        {
            List<Ped> supplyPeds = new List<Ped>() { supply1ped1,supply1ped2,supply1ped3,supply1ped4,supply1ped5,supply2ped1,supply2ped2,supply100ped1,supply100ped2,supply100ped3,supply100ped4,supply100ped5,supply100ped6,supply100ped7,supply100ped8,supply100ped9,supply100ped10,supply101ped1,supply101ped2,supply101ped3,supply101ped4,supply101ped5,supply101ped6 };
            return supplyPeds;
        }

        public static List<Vehicle> getSupplyVehicles()
        {
            List<Vehicle> supplyVehicles = new List<Vehicle>() { supply1vehicle1,supply1vehicle2,supply1vehicle3,supply2vehicle1,supply100vehicle1,supply100vehicle2,supply100vehicle3,supply100vehicle4,supply100vehicle5,supply100vehicle6,supply101vehicle1,supply101vehicle2,supply101vehicle3,supply101vehicle4, supply102vehicle1,supply103vehicle1, supply103vehicle2, supply103vehicle3, supply104vehicle1 };
            return supplyVehicles;
        }

        public static List<Prop> getSupplyProps()
        {
            List<Prop> supplyProps = new List<Prop>() { supply1crate,supply2crate,supply101crate1,supply101crate2,supply101crate3, supply104crate1 };
            return supplyProps;
        }

        public static List<Ped> getSetupPeds()
        {
            List<Ped> supplyPeds = new List<Ped>() { setup1ped1,setup1ped2,setup1ped3 };
            return supplyPeds;
        }

        public static List<Vehicle> getSetupVehicles()
        {
            List<Vehicle> supplyVehicles = new List<Vehicle>() { setup1vehicle1,setup1vehicle2,setup1vehicle3 };
            return supplyVehicles;
        }

        public static List<Prop> getDecorProps()
        {
            List<Prop> decorProps = new List<Prop>() { decorProp1,decorProp2,decorProp3,decorProp4,decorProp5,decorProp6,decorProp7,decorProp8,decorProp9,decorProp10,decorProp11,decorProp12,decorProp13,decorProp14,decorProp15,decorProp16,decorProp17,decorProp18,decorProp19,decorProp20,decorProp21,decorProp22,decorProp23,decorProp24,decorProp25,decorProp26,decorProp27,decorProp28,decorProp29,decorProp30,decorProp31,decorProp32,decorProp33,decorProp34,decorProp35 };
            return decorProps;
        }

    }
}
